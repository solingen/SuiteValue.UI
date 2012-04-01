﻿using System;

namespace CodeValue.CodeLight.Mvvm.Validation
{
    public class RequiredRule : SimpleRule
    {
        private static readonly Func<object, string, bool> requiredAction = (o, s) =>
                                                               {
                                                                   var type = o.GetType();
                                                                   var prop = type.GetProperty(s);
                                                                   var value = prop.GetValue(o, null);
                                                                   return value != null;
                                                               };


        public RequiredRule(string propertyName, string brokenDescription)
            : base(propertyName, brokenDescription, o => requiredAction(o, propertyName))
        {
        }
    }
}