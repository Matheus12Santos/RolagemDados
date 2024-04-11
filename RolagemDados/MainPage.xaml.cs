namespace RolagemDados
{
    public partial class MainPage : ContentPage
    {  
            Picker picker;
            Button rollButton;
            Label resultLabel;

            public MainPage()
            {
                InitializeComponent();
                CriarLayout();
            }

            private void CriarLayout()
            {
                StackLayout layout = new StackLayout
                {
                    Padding = new Thickness(20)
                };

                void RollButton_Clicked(object sender, EventArgs e)
                {
                    int numLados = int.Parse(picker.SelectedItem.ToString().Split(' ')[0]);
                    Random random = new Random();
                    int resultado = random.Next(1, numLados + 1);
                    resultLabel.Text = $"{resultado}";
                }

                picker = new Picker
                {
                    Title = "Quantidade de lados",
                    Margin = new Thickness(0, 0, 0, 20)
                };
                picker.Items.Add("4 lados");
                picker.Items.Add("6 lados");
                picker.Items.Add("10 lados");
                picker.Items.Add("20 lados");
                picker.Items.Add("100 lados"); 

                rollButton = new Button
                {
                    Text = "Rolar",
                    BackgroundColor = Color.FromHex("#D3D3D3"),                  
                    CornerRadius = 5,
                    Margin = new Thickness(0, 0, 0, 20)
                };
                rollButton.Clicked += RollButton_Clicked;

                
                resultLabel = new Label
                {
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    HorizontalOptions = LayoutOptions.Center
                };

                layout.Children.Add(resultLabel);
                layout.Children.Add(picker);
                layout.Children.Add(rollButton);
                

                Content = layout;
            }          
    }

}
