using System.ComponentModel.Composition;
using DevExpress.CodeRush.Common;

namespace CR_ObjectInitializerToConstructor
{
  [Export(typeof(IVsixPluginExtension))]
  public class CR_ObjectInitializerToConstructorExtension : IVsixPluginExtension { }
}