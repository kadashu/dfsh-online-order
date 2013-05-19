namespace VBWebBrowserNew.My.Resources
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;
    using System.Resources;
    using System.Runtime.CompilerServices;

    [StandardModule, HideModuleName, CompilerGenerated, DebuggerNonUserCode, GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    internal sealed class Resources
    {
        private static CultureInfo resourceCulture;
        private static System.Resources.ResourceManager resourceMan;

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        internal static string fetion
        {
            get
            {
                return ResourceManager.GetString("fetion", resourceCulture);
            }
        }

        internal static string id
        {
            get
            {
                return ResourceManager.GetString("id", resourceCulture);
            }
        }

        internal static string local
        {
            get
            {
                return ResourceManager.GetString("local", resourceCulture);
            }
        }

        internal static string login_after
        {
            get
            {
                return ResourceManager.GetString("login_after", resourceCulture);
            }
        }

        internal static string login_before
        {
            get
            {
                return ResourceManager.GetString("login_before", resourceCulture);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    System.Resources.ResourceManager manager2 = new System.Resources.ResourceManager("VBWebBrowserNew.Resources", typeof(VBWebBrowserNew.My.Resources.Resources).Assembly);
                    resourceMan = manager2;
                }
                return resourceMan;
            }
        }

        internal static string sms
        {
            get
            {
                return ResourceManager.GetString("sms", resourceCulture);
            }
        }

        internal static string work_after
        {
            get
            {
                return ResourceManager.GetString("work_after", resourceCulture);
            }
        }

        internal static string work_before
        {
            get
            {
                return ResourceManager.GetString("work_before", resourceCulture);
            }
        }
    }
}

