using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace XForms.Pages.ClassHierarchy
{
    public class TypeInformation
    {
        private bool isBaseGenericType;
        private Type baseGenericTypeDef;

        public Type Type { private set; get; }
        public Type BaseType { private set; get; }
        public bool IsXamarinForms { private set; get; }

        public TypeInformation(Type type, bool isXamarinForms)
        {
            Type = type;
            IsXamarinForms = isXamarinForms;
            TypeInfo typeInfo = type.GetTypeInfo();
            BaseType = typeInfo.BaseType;
        }

        public bool IsDerivedDirectlyFrom(Type parentType)
        {
            if (BaseType != null && isBaseGenericType)
            {
                if (baseGenericTypeDef == parentType)
                {
                    return true;
                }
            }

            else if (BaseType == parentType)
            {
                return true;
            }

            return false;
        }
    }
}
