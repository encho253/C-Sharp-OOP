namespace VersionАttribute
{
    using System;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public sealed class AssemblyVersionAttribute : Attribute
    {        
        public AssemblyVersionAttribute(string version)
        {
            this.Version = version;
        }

        public string Version { get; set; }
    }
}
