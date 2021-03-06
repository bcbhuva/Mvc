// <auto-generated />
namespace Microsoft.AspNetCore.Mvc.TagHelpers
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.Mvc.TagHelpers.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// Cannot determine the '{0}' attribute for {1}. The following attributes are mutually exclusive:
        /// </summary>
        internal static string CannotDetermineAttributeFor
        {
            get => GetString("CannotDetermineAttributeFor");
        }

        /// <summary>
        /// Cannot determine the '{0}' attribute for {1}. The following attributes are mutually exclusive:
        /// </summary>
        internal static string FormatCannotDetermineAttributeFor(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("CannotDetermineAttributeFor"), p0, p1);

        /// <summary>
        /// Cannot override the '{0}' attribute for {1}. An {1} with a specified '{0}' must not have attributes starting with '{2}' or an '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}' or '{11}' attribute.
        /// </summary>
        internal static string AnchorTagHelper_CannotOverrideHref
        {
            get => GetString("AnchorTagHelper_CannotOverrideHref");
        }

        /// <summary>
        /// Cannot override the '{0}' attribute for {1}. An {1} with a specified '{0}' must not have attributes starting with '{2}' or an '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}' or '{11}' attribute.
        /// </summary>
        internal static string FormatAnchorTagHelper_CannotOverrideHref(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9, object p10, object p11)
            => string.Format(CultureInfo.CurrentCulture, GetString("AnchorTagHelper_CannotOverrideHref"), p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);

        /// <summary>
        /// Cannot override the '{0}' attribute for {1}. A {1} with a specified '{0}' must not have attributes starting with '{2}' or an '{3}', '{4}', '{5}', '{6}', '{7}', '{8}' or '{9}' attribute.
        /// </summary>
        internal static string FormTagHelper_CannotOverrideAction
        {
            get => GetString("FormTagHelper_CannotOverrideAction");
        }

        /// <summary>
        /// Cannot override the '{0}' attribute for {1}. A {1} with a specified '{0}' must not have attributes starting with '{2}' or an '{3}', '{4}', '{5}', '{6}', '{7}', '{8}' or '{9}' attribute.
        /// </summary>
        internal static string FormatFormTagHelper_CannotOverrideAction(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9)
            => string.Format(CultureInfo.CurrentCulture, GetString("FormTagHelper_CannotOverrideAction"), p0, p1, p2, p3, p4, p5, p6, p7, p8, p9);

        /// <summary>
        /// Unexpected '{1}' expression result type '{2}' for {0}. '{1}' must be of type '{3}' or '{4}' that can be parsed as a '{3}' if '{5}' is '{6}'.
        /// </summary>
        internal static string InputTagHelper_InvalidExpressionResult
        {
            get => GetString("InputTagHelper_InvalidExpressionResult");
        }

        /// <summary>
        /// Unexpected '{1}' expression result type '{2}' for {0}. '{1}' must be of type '{3}' or '{4}' that can be parsed as a '{3}' if '{5}' is '{6}'.
        /// </summary>
        internal static string FormatInputTagHelper_InvalidExpressionResult(object p0, object p1, object p2, object p3, object p4, object p5, object p6)
            => string.Format(CultureInfo.CurrentCulture, GetString("InputTagHelper_InvalidExpressionResult"), p0, p1, p2, p3, p4, p5, p6);

        /// <summary>
        /// Unexpected expression result value '{1}' for {0}. '{1}' cannot be parsed as a '{2}'.
        /// </summary>
        internal static string InputTagHelper_InvalidStringResult
        {
            get => GetString("InputTagHelper_InvalidStringResult");
        }

        /// <summary>
        /// Unexpected expression result value '{1}' for {0}. '{1}' cannot be parsed as a '{2}'.
        /// </summary>
        internal static string FormatInputTagHelper_InvalidStringResult(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("InputTagHelper_InvalidStringResult"), p0, p1, p2);

        /// <summary>
        /// '{1}' must not be null for {0} if '{2}' is '{3}'.
        /// </summary>
        internal static string InputTagHelper_ValueRequired
        {
            get => GetString("InputTagHelper_ValueRequired");
        }

        /// <summary>
        /// '{1}' must not be null for {0} if '{2}' is '{3}'.
        /// </summary>
        internal static string FormatInputTagHelper_ValueRequired(object p0, object p1, object p2, object p3)
            => string.Format(CultureInfo.CurrentCulture, GetString("InputTagHelper_ValueRequired"), p0, p1, p2, p3);

        /// <summary>
        /// The {2} was unable to provide metadata about '{1}' expression value '{3}' for {0}.
        /// </summary>
        internal static string TagHelpers_NoProvidedMetadata
        {
            get => GetString("TagHelpers_NoProvidedMetadata");
        }

        /// <summary>
        /// The {2} was unable to provide metadata about '{1}' expression value '{3}' for {0}.
        /// </summary>
        internal static string FormatTagHelpers_NoProvidedMetadata(object p0, object p1, object p2, object p3)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelpers_NoProvidedMetadata"), p0, p1, p2, p3);

        /// <summary>
        /// The value of argument '{0}' ({1}) is invalid for Enum type '{2}'.
        /// </summary>
        internal static string InvalidEnumArgument
        {
            get => GetString("InvalidEnumArgument");
        }

        /// <summary>
        /// The value of argument '{0}' ({1}) is invalid for Enum type '{2}'.
        /// </summary>
        internal static string FormatInvalidEnumArgument(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("InvalidEnumArgument"), p0, p1, p2);

        /// <summary>
        /// The attribute '{0}' does not exist in the {1}.
        /// </summary>
        internal static string TagHelperOutput_AttributeDoesNotExist
        {
            get => GetString("TagHelperOutput_AttributeDoesNotExist");
        }

        /// <summary>
        /// The attribute '{0}' does not exist in the {1}.
        /// </summary>
        internal static string FormatTagHelperOutput_AttributeDoesNotExist(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelperOutput_AttributeDoesNotExist"), p0, p1);

        /// <summary>
        /// The '{0}' property of '{1}' must not be null.
        /// </summary>
        internal static string PropertyOfTypeCannotBeNull
        {
            get => GetString("PropertyOfTypeCannotBeNull");
        }

        /// <summary>
        /// The '{0}' property of '{1}' must not be null.
        /// </summary>
        internal static string FormatPropertyOfTypeCannotBeNull(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("PropertyOfTypeCannotBeNull"), p0, p1);

        /// <summary>
        /// Cannot override the '{0}' attribute for &lt;{1}&gt;. &lt;{1}&gt; elements with a specified '{0}' must not have attributes starting with '{2}' or an '{3}', '{4}', '{5}', '{6}', '{7}', '{8}' or '{9}' attribute.
        /// </summary>
        internal static string FormActionTagHelper_CannotOverrideFormAction
        {
            get => GetString("FormActionTagHelper_CannotOverrideFormAction");
        }

        /// <summary>
        /// Cannot override the '{0}' attribute for &lt;{1}&gt;. &lt;{1}&gt; elements with a specified '{0}' must not have attributes starting with '{2}' or an '{3}', '{4}', '{5}', '{6}', '{7}', '{8}' or '{9}' attribute.
        /// </summary>
        internal static string FormatFormActionTagHelper_CannotOverrideFormAction(object p0, object p1, object p2, object p3, object p4, object p5, object p6, object p7, object p8, object p9)
            => string.Format(CultureInfo.CurrentCulture, GetString("FormActionTagHelper_CannotOverrideFormAction"), p0, p1, p2, p3, p4, p5, p6, p7, p8, p9);

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
