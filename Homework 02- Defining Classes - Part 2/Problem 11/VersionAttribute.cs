using System;
namespace Problem_11
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    
    public class VersionAttribute : Attribute
    {
        private string version;

        public string Version
        {
            get { return this.version; }
            set { this.version = value;}
        }

        public VersionAttribute(string version)
        {
            this.Version = version;
        }
    }
}