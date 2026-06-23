using Core.Enums;
using Core.Models;
using Core.Utils;
using System.Text;
using Core.Insfrastructure.CachingData;
using System.Reflection;
using System.Text.Json;
using Core.Insfrastructure.Caching;


namespace Core.Insfrastructure
{

    public class MessageModel
    {
        public List<MessageDataModel> MasterMsg { get; set; }
        public List<MessageDataModel> ReturnMsg { get; set; }
    }

    public class DynamicCachingMessageModel
    {
        public MessageDataModel MasterMsg { get; set; }
        public MessageDataModel ReturnMsg { get; set; }
    }

    public class MessageDataModel
    {
        public Int64 MsgId { get; set; }
        public string MsgKey { get; set; }
        public string MsgEng { get; set; }
        public string MsgHin { get; set; }
    }
    public  class DynamicMessage
    {

        private  Dictionary<string, MessageModel> _messages = new Dictionary<string, MessageModel>();

        public  ResponseModel GetCommonReturnMessage(ResponseModel model, string masterKey, string msgKey, string language, int cnt = 0)
        {
            MessageDataModel messageMasterModel = GetMessage(masterKey, MessageType.MasterMsg.ToString(), null, language);
            MessageDataModel messageReturnModel = GetMessage(msgKey, MessageType.ReturnMsg.ToString(), null, language);

            StringBuilder sb = new StringBuilder();
            if (language != null && (language.ToUpper() == "HI" || language.ToUpper() == "HIN"))
                sb.Append(messageMasterModel?.MsgHin + " " + messageReturnModel?.MsgHin);
            else
                sb.Append(messageMasterModel?.MsgEng + " " + messageReturnModel?.MsgEng);
            if (cnt > 0)
            {
                model.Message = cnt + " " + sb.ToString();
            }
            else
            {
                model.Message = sb.ToString();
            }
            return model;
        }

        //Above function is not useful for the perticular  case
        public  ResponseModel GetCommonReturnMessageCache(ResponseModel model, string masterKey, string msgKey, string language, ICacheService cacheService, int cnt = 0)
        {
            try
            {

                DynamicCachingMessageModel messageModel = GetDynamicCachingMessage(masterKey, MessageType.MasterMsg.ToString(), msgKey, MessageType.ReturnMsg.ToString(), cacheService, language);
                //MessageDataModel messageReturnModel = GetDynamicCachingMessage(msgKey, MessageType.ReturnMsg.ToString(), cacheService);


                StringBuilder sb = new StringBuilder();
                if (language != null && (language.ToUpper() == "HI" || language.ToUpper() == "HIN"))
                    sb.Append(messageModel.MasterMsg?.MsgHin + " " + messageModel.ReturnMsg?.MsgHin);
                else
                    sb.Append(messageModel.MasterMsg?.MsgEng + " " + messageModel.ReturnMsg?.MsgEng);

                if (cnt > 0)
                {
                    model.Message = cnt + " " + sb.ToString();
                }
                else
                {
                    model.Message = sb.ToString();
                }
                return model;
            }
            catch (Exception ex)
            {
                LogUtility LogUtility = new LogUtility(); LogUtility.WriteEventErrorLog(ex, string.Empty, MethodBase.GetCurrentMethod().DeclaringType.ToString() + "." + MethodBase.GetCurrentMethod().Name, JsonSerializer.Serialize(model));
                model = GetCommonReturnMessageCache(model, "", Enums.ReturnMessage.SorryAnErrorOccuredWhileProcessingYourRequest.ToString(), language, cacheService, 0);
                model.Status = Enums.URM.Status.Error;
                return model;
            }
        }

        //Set the Msg into cache while fetching from Database
        public  MessageModel SetDynamicCachingMessage(ICacheService _cacheService, string language)
        {
            ConfigurationManger ConfigurationManger = new ConfigurationManger();

            MessageModel model = new MessageModel();
            ResponseModel returnModel = new ResponseModel(Enums.URM.Status.Alert);
            try
            {

                if (_cacheService != null)
                {

                    EnumUtility EnumUtility = new EnumUtility();
                    string cacheMemoryKey = EnumUtility.GetDescription(CacheKeysApi.MessageModel);
                    var MemoryCachedData = _cacheService.GetData<MessageModel>(cacheMemoryKey);

               if (MemoryCachedData is not null && MemoryCachedData.MasterMsg is not null && MemoryCachedData.ReturnMsg is not null) 
                    {

                        model = MemoryCachedData;

                        //_cacheService.SetData<MessageModel>(cacheMemoryKey, model, DateTime.Now.AddHours(cacheTimeHours)); //Caching data for 24 hours
                        //_cacheService.SetData<MessageModel>(cacheMemoryKey, model, DateTime.Now.AddMinutes(1)); //Testing for 1 Min

                    }
                    else
                    {
                        ApiFilterModel apiRequestModel = new ApiFilterModel();
                        var url = ConfigurationManger.AppSetting["ServiceURL:CFG"];
                        var cacheTimeHours = ConfigurationManger.AppSetting.GetValue<int>("CacheTime");
                        LogUtility LogUtility = new LogUtility();
                        returnModel = LogUtility.GetDynamicMessage(apiRequestModel, url);
                        ConversionUtility ConversionUtility = new ConversionUtility();
                        model = ConversionUtility.ConvertFromDynamicObject<MessageModel>(returnModel.CustomObject);
                        if (_cacheService != null)
                        {
                            _cacheService.SetData<MessageModel>(cacheMemoryKey, model, DateTime.Now.AddHours(cacheTimeHours)); //Caching data for 24 hours
                                                                                                                               //_cacheService.SetData<MessageModel>(cacheMemoryKey, model, DateTime.Now.AddMinutes(1)); //Testing for 1 Min
                        }
                    } 
                }
                return model;
            }
            catch (Exception ex)
            {
                LogUtility LogUtility = new LogUtility(); LogUtility.WriteEventErrorLog(ex, string.Empty, MethodBase.GetCurrentMethod().DeclaringType.ToString() + "." + MethodBase.GetCurrentMethod().Name, JsonSerializer.Serialize(model));
                returnModel = GetCommonReturnMessageCache(returnModel, "", Enums.ReturnMessage.SorryAnErrorOccuredWhileProcessingYourRequest.ToString(), language, _cacheService, 0);
                returnModel.Status = Enums.URM.Status.Error;
                return model;
            }


        }

        //Get the Msg from cache if present                                                                       
        public  DynamicCachingMessageModel GetDynamicCachingMessage(string masterKey, string MasterMsgType, string ReturnKey, string ReturnMsgType, ICacheService cacheService, string language)
        {
            MessageDataModel ReturnModal = new MessageDataModel();
            MessageModel messageModel = null;
            DynamicCachingMessageModel dynamicCachingMessageModel = new DynamicCachingMessageModel();
            try
            {

                messageModel = SetDynamicCachingMessage(cacheService, language);
                // string cacheMemoryKey = EnumUtility.GetDescription(CacheKeysApi.MessageModel);
                // messageModel = cacheService.GetOrAdd(cacheMemoryKey, () => SetDynamicCachingMessage(cacheService), TimeSpan.FromMinutes(60));

                if (messageModel != null)
                {
                    if (MasterMsgType == "MasterMsg")
                    {
                        if (!String.IsNullOrEmpty(masterKey))
                        {
                            ReturnModal = messageModel.MasterMsg
                                               .Where(s => s.MsgKey.ToUpper() == masterKey.ToUpper())
                                               .Select(s => new MessageDataModel()
                                               {
                                                   MsgId = s.MsgId,
                                                   MsgKey = s.MsgKey,
                                                   MsgEng = s.MsgEng,
                                                   MsgHin = s.MsgHin
                                               }).FirstOrDefault();
                            dynamicCachingMessageModel.MasterMsg = ReturnModal; 
                        }
                    }
                    if (ReturnMsgType == "ReturnMsg")
                    {
                        ReturnModal = messageModel.ReturnMsg
                            .Where(s => s.MsgKey.ToUpper() == ReturnKey.ToUpper())
                            .Select(s => new MessageDataModel()
                            {
                                MsgId = s.MsgId,
                                MsgKey = s.MsgKey,
                                MsgEng = s.MsgEng,
                                MsgHin = s.MsgHin
                            }).FirstOrDefault();
                        dynamicCachingMessageModel.ReturnMsg = ReturnModal;
                    }
                }
                return dynamicCachingMessageModel;
            }
            catch (Exception ex)
            {
                LogUtility LogUtility = new LogUtility(); LogUtility.WriteEventErrorLog(ex, string.Empty, MethodBase.GetCurrentMethod().DeclaringType.ToString() + "." + MethodBase.GetCurrentMethod().Name, JsonSerializer.Serialize(dynamicCachingMessageModel));
                return dynamicCachingMessageModel;
            }


        }

        //  To review
        public  MessageModel SetMessage(ICacheService _cacheService, string language)//null
        {
            MessageModel model = new MessageModel();
            EnumUtility EnumUtility = new EnumUtility();
            ResponseModel returnModel = new ResponseModel(Enums.URM.Status.Alert);
            ConfigurationManger ConfigurationManger = new ConfigurationManger();
            try
            {
                if (_cacheService != null)
                {
                    //   -----Not executing this code-------- -
                    string cacheMemoryKey = EnumUtility.GetDescription(CacheKeysApi.MessageModel);
                    var MemoryCachedData = _cacheService.GetData<IEnumerable<MessageModel>>(cacheMemoryKey);
                    if (model != null && MemoryCachedData == null)
                    {
                        ApiFilterModel apiRequestModel = new ApiFilterModel();
                        var url = ConfigurationManger.AppSetting["ServiceURL:CFG"];
                        LogUtility LogUtility = new LogUtility();
                        returnModel = LogUtility.GetDynamicMessage(apiRequestModel, url);
                        ConversionUtility ConversionUtility = new ConversionUtility();
                        model = ConversionUtility.ConvertFromDynamicObject<MessageModel>(returnModel.CustomObject);
                        _cacheService.SetData<IEnumerable<MessageModel>>(cacheMemoryKey, MemoryCachedData, DateTimeOffset.Now.AddMinutes((int)Enums.CacheHours.Minute60));
                    }
                }
                else
                {
                    ApiFilterModel apiRequestModel = new ApiFilterModel();
                    var url = ConfigurationManger.AppSetting["ServiceURL:CFG"];
                    LogUtility LogUtility = new LogUtility();
                    returnModel = LogUtility.GetDynamicMessage(apiRequestModel, url);
                    ConversionUtility ConversionUtility = new ConversionUtility();
                    model = ConversionUtility.ConvertFromDynamicObject<MessageModel>(returnModel.CustomObject);
                }
                return model;
            }
            catch (Exception ex)
            {
                LogUtility LogUtility = new LogUtility(); LogUtility.WriteEventErrorLog(ex, string.Empty, MethodBase.GetCurrentMethod().DeclaringType.ToString() + "." + MethodBase.GetCurrentMethod().Name, JsonSerializer.Serialize(model));
                returnModel = GetCommonReturnMessageCache(returnModel, "", Enums.ReturnMessage.SorryAnErrorOccuredWhileProcessingYourRequest.ToString(), language, _cacheService, 0);
                returnModel.Status = Enums.URM.Status.Error;
                return model;
            }


        }
        //  To review
        public  MessageDataModel GetMessage(string key, string MsgType, ICacheService _cacheService, string language)//null
        {
            EnumUtility EnumUtility = new EnumUtility();
            MessageDataModel retModel = new MessageDataModel();
            MessageModel messageModel = new MessageModel();
            try
            {
                if (_cacheService != null)
                {
                    // ------------Not executing this code due to _casheService is null-------- -
                    string cacheMemoryKey = EnumUtility.GetDescription(CacheKeysApi.MessageModel);
                    var MemoryCachedData = _cacheService.GetData<MessageModel>(cacheMemoryKey);

                    if (MemoryCachedData != null)
                    {
                        messageModel = MemoryCachedData;
                    }
                    else
                    {
                        messageModel = SetMessage(_cacheService, language);
                    }

                    if (MsgType == "MasterMsg")
                    {
                        retModel = messageModel.MasterMsg.Where(s => s.MsgKey.ToUpper() == key.ToUpper())
                            .Select(s => new MessageDataModel()
                            {
                                MsgId = s.MsgId,
                                MsgKey = s.MsgKey,
                                MsgEng = s.MsgEng,
                                MsgHin = s.MsgHin
                            }).FirstOrDefault();
                    }
                    if (MsgType == "ReturnMsg")
                    {
                        retModel = messageModel.ReturnMsg.Where(s => s.MsgKey.ToUpper() == key.ToUpper())
                            .Select(s => new MessageDataModel()
                            {
                                MsgId = s.MsgId,
                                MsgKey = s.MsgKey,
                                MsgEng = s.MsgEng,
                                MsgHin = s.MsgHin
                            }).FirstOrDefault();
                    }
                }
                else
                {
                    messageModel = SetMessage(_cacheService, language);
                    if (MsgType == "MasterMsg")
                    {
                        retModel = messageModel.MasterMsg.Where(s => s.MsgKey.ToUpper() == key.ToUpper())
                            .Select(s => new MessageDataModel()
                            {
                                MsgId = s.MsgId,
                                MsgKey = s.MsgKey,
                                MsgEng = s.MsgEng,
                                MsgHin = s.MsgHin
                            }).FirstOrDefault();
                    }
                    if (MsgType == "ReturnMsg")
                    {
                        retModel = messageModel.ReturnMsg.Where(s => s.MsgKey.ToUpper() == key.ToUpper())
                            .Select(s => new MessageDataModel()
                            {
                                MsgId = s.MsgId,
                                MsgKey = s.MsgKey,
                                MsgEng = s.MsgEng,
                                MsgHin = s.MsgHin
                            }).FirstOrDefault();
                    }
                }
                return retModel;
            }
            catch (Exception ex)
            {
                LogUtility LogUtility = new LogUtility(); LogUtility.WriteEventErrorLog(ex, string.Empty, MethodBase.GetCurrentMethod().DeclaringType.ToString() + "." + MethodBase.GetCurrentMethod().Name, JsonSerializer.Serialize(retModel));
                return retModel;
            }

        }


        #region MyRegion
        public  ResponseModel GetCommonReturnMessageCacheNew(ResponseModel model, string masterKey, string msgKey, string language, CacheManager cacheService, int cnt = 0)
        {
            DynamicCachingMessageModel messageModel = GetDynamicCachingMessageNew(masterKey, MessageType.MasterMsg.ToString(), msgKey, MessageType.ReturnMsg.ToString(), cacheService);
            //MessageDataModel messageReturnModel = GetDynamicCachingMessage(msgKey, MessageType.ReturnMsg.ToString(), cacheService);


            StringBuilder sb = new StringBuilder();
            if (language != null && (language.ToUpper() == "HI" || language.ToUpper() == "HIN"))
                sb.Append(messageModel.MasterMsg?.MsgHin + " " + messageModel.ReturnMsg?.MsgHin);
            else
                sb.Append(messageModel.MasterMsg?.MsgEng + " " + messageModel.ReturnMsg?.MsgEng);

            if (cnt > 0)
            {
                model.Message = cnt + " " + sb.ToString();
            }
            else
            {
                model.Message = sb.ToString();
            }
            return model;
        }

        //Set the Msg into cache while fetching from Database
        public  MessageModel SetDynamicCachingMessageNew(CacheManager _cacheService)
        {
            MessageModel model = new MessageModel();
            ResponseModel returnModel = new ResponseModel(Enums.URM.Status.Alert);
            ConfigurationManger ConfigurationManger = new ConfigurationManger();
            //string cacheMemoryKey = EnumUtility.GetDescription(CacheKeysApi.MessageModel);
            //var MemoryCachedData = _cacheService.GetData<MessageModel>(cacheMemoryKey);

            //if (MemoryCachedData != null)
            //{
            //    model = MemoryCachedData;
            //}
            //else
            {
                ApiFilterModel apiRequestModel = new ApiFilterModel();
                var url = ConfigurationManger.AppSetting["ServiceURL:CFG"];
                var cacheTimeHours = ConfigurationManger.AppSetting.GetValue<int>("CacheTime");
                LogUtility LogUtility = new LogUtility();
                returnModel = LogUtility.GetDynamicMessage(apiRequestModel, url);
                ConversionUtility ConversionUtility = new ConversionUtility();
                model = ConversionUtility.ConvertFromDynamicObject<MessageModel>(returnModel.CustomObject);
                if (_cacheService != null)
                {
                    //  _cacheService.SetData<MessageModel>(cacheMemoryKey, model, DateTime.Now.AddHours(cacheTimeHours)); //Caching data for 24 hours
                    //_cacheService.SetData<MessageModel>(cacheMemoryKey, model, DateTime.Now.AddMinutes(1)); //Testing for 1 Min
                }
            }
            return model;
        }

        //Get the Msg from cache if present                                                                       
        public  DynamicCachingMessageModel GetDynamicCachingMessageNew(string masterKey, string MasterMsgType, string ReturnKey, string ReturnMsgType, CacheManager cacheService)
        {
            EnumUtility EnumUtility = new EnumUtility();
            MessageDataModel ReturnModal = new MessageDataModel();
            MessageModel messageModel = null;
            DynamicCachingMessageModel dynamicCachingMessageModel = new DynamicCachingMessageModel();
            //messageModel = SetDynamicCachingMessage(cacheService);
            string cacheMemoryKey = EnumUtility.GetDescription(CacheKeysApi.MessageModel);
            messageModel = cacheService.GetOrAdd(cacheMemoryKey, () => SetDynamicCachingMessageNew(cacheService), TimeSpan.FromMinutes(60));

            if (messageModel != null)
            {
                if (MasterMsgType == "MasterMsg")
                {
                    ReturnModal = messageModel.MasterMsg
                        .Where(s => s.MsgKey.ToUpper() == masterKey.ToUpper())
                        .Select(s => new MessageDataModel()
                        {
                            MsgId = s.MsgId,
                            MsgKey = s.MsgKey,
                            MsgEng = s.MsgEng,
                            MsgHin = s.MsgHin
                        }).FirstOrDefault();
                    dynamicCachingMessageModel.MasterMsg = ReturnModal;
                }
                if (ReturnMsgType == "ReturnMsg")
                {
                    ReturnModal = messageModel.ReturnMsg
                        .Where(s => s.MsgKey.ToUpper() == ReturnKey.ToUpper())
                        .Select(s => new MessageDataModel()
                        {
                            MsgId = s.MsgId,
                            MsgKey = s.MsgKey,
                            MsgEng = s.MsgEng,
                            MsgHin = s.MsgHin
                        }).FirstOrDefault();
                    dynamicCachingMessageModel.ReturnMsg = ReturnModal;
                }
            }
            return dynamicCachingMessageModel;
        }

        #endregion
    }

}

