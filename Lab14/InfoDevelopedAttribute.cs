using System;

namespace Lab14
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    internal class InfoDevelopedAttribute : Attribute
    {
        public string DeveloperName { get; set; }
        public string Organization { get; set; }
        public InfoDevelopedAttribute(string developerName, string organization)
        {
            this.DeveloperName = developerName;
            this.Organization = organization;
        }
    }
}

