using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Effects;

namespace BlurEffectTest.ViewModels
{
    class SplashScreen
    {
        #region Blur Effect
        static readonly BlurEffect MyBlur = new();
        
        public static void ShowBlurEffectAllWindow()
        {
            try
            {
                MyBlur.Radius = 20;
                MyBlur.RenderingBias = RenderingBias.Performance;
                
                foreach (Window window in Application.Current.Windows)
                {
                    if (window.Title.Contains("MainWindow", StringComparison.OrdinalIgnoreCase))
                    {
                        window.Effect = MyBlur;
                    }
                }
            }
            catch { }
        }

        public static void StopBlurEffectAllWindow()
        {
            try
            {
                foreach (Window window in Application.Current.Windows)
                {
                    window.Effect = null;
                }
            }
            catch { }
        }
        #endregion
    }
}
