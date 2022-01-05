using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MauiModalTest
{
    public class ModalPage : ContentPage
    {
        private readonly Label _errorText;

        public ModalPage()
        {
            Background = Brush.White;
            var button = new Button() { Text = "Close Modal" };
            button.Clicked += Button_Clicked;
            _errorText = new Label();
            _errorText.TextColor = Colors.Black;

            _errorText.Margin = new Thickness(20);

            Content = new StackLayout
            {
                Children = {
                    button, _errorText
                }
            };
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PopModalAsync(true);
            }
            catch (Exception exception)
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Error: {exception.Message}");
                sb.Append(exception.StackTrace);
                _errorText.Text = sb.ToString();
                Debug.WriteLine(exception);
            }
        }
    }
}