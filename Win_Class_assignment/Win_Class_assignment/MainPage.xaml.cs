using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Capture;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Win_Class_assignment
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
           
        }

        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
            private async void Button_Click(object sender, RoutedEventArgs e) {

                CameraCaptureUI capture = new CameraCaptureUI();
                capture.PhotoSettings.CroppedAspectRatio = new Size(16, 9);
                StorageFile file = await capture.CaptureFileAsync(CameraCaptureUIMode.Photo); 
                IRandomAccessStream filestream = await file.OpenAsync(FileAccessMode.Read);

               

                if (a == 0)
                {

                    BitmapImage img = new BitmapImage(); 
                     img.SetSource(filestream); 
                     img_viewer.Source = img;
                     a = 1;
                }
                else if(b==0)
                {
                    BitmapImage img = new BitmapImage();
                    img.SetSource(filestream);
                    img_viewer2.Source = img;
                    b = 1;
                }
                else if (c == 0)
                {
                    BitmapImage img = new BitmapImage();
                    img.SetSource(filestream);
                    img_viewer3.Source = img;
                }
                else if (d == 0)
                {
                    BitmapImage img = new BitmapImage();
                    img.SetSource(filestream);
                    img_viewer4.Source = img;
                }


 txt.Visibility = Visibility.Visible;
            
            }




        }
    }

