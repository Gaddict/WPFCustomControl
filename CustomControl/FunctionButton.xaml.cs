using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomControl
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class FunctionButton : Button
    {
        /// <summary>
        /// FunctionButton を表示している Window
        /// </summary>
        private Window parentWindow;

        /// <summary>
        /// Function プロパティに設定できる値
        /// </summary>
        public enum Functions
        {
            None,
            F1,
            F2,
            F3,
            F4,
            F5,
            F6,
            F7,
            F8,
            F9,
            F10,
            F11,
            F12,
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FunctionButton()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty FunctionProperty = DependencyProperty.Register("Function",
                                                                                                 typeof(Functions),
                                                                                                 typeof(FunctionButton),
                                                                                                 new FrameworkPropertyMetadata(Functions.None,
                                                                                                                               FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                                                                                                                               OnFunctionChanged));

        public Functions Function
        {
            get
            {
                return (Functions)this.GetValue(FunctionProperty);
            }

            set
            {
                this.SetValue(FunctionProperty, value);
            }
        }

        private static void OnFunctionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            FunctionButton fb = d as FunctionButton;

            if (fb != null)
            {


            }
        }


    }
}
