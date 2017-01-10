using System;
using System.Collections.Generic;

namespace XForms.Pages.ClassHierarchy
{
    public class ClassAndSubclasses
    {
        public Type Type { private set; get; }
        public bool IsXamarinForms { private set; get; }
        public List<ClassAndSubclasses> Subclasses { private set; get; }

        public ClassAndSubclasses(Type parent, bool isXamarinForms)
        {
            Type = parent;
            IsXamarinForms = isXamarinForms;
            Subclasses = new List<ClassAndSubclasses>();
        }
    }
}
