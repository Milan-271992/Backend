using Core.Enums;
using System.Data;

namespace Core.Models
{
#nullable disable
    public class CommonDbParameter
    {
        private string _ParameterName = "";
        private object _Value;
        private CommonDbType _dbType;
        private ParameterDirection _Direction;
        public CommonDbParameter()
        {
            
        }
        public CommonDbParameter(string parameterName, CommonDbType dbType, object value)
        {
            _ParameterName = parameterName;
            _dbType = dbType;
            _Value = value;
            _Direction = ParameterDirection.Input;
        }
        public CommonDbParameter(string parameterName, CommonDbType dbType, object value, ParameterDirection direction)
        {
            _ParameterName = parameterName;
            _dbType = dbType;
            _Value = value;
            _Direction = direction;
        }


        public String ParameterName
        {
            get
            {
                return _ParameterName;
            }
            set
            {
                _ParameterName = value;
            }
        }
        public object Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
            }
        }
        public ParameterDirection Direction
        {
            get
            {
                return _Direction;
            }
            set
            {
                _Direction = value;
            }
        }
        public CommonDbType DbType
        {
            get
            {
                return _dbType;
            }
            set
            {
                _dbType = value;
            }
        }
    }
}
