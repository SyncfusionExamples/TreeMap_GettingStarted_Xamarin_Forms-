using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Syncfusion.SfTreeMap.XForms;

namespace TreeMap
{
    public partial class MainPage : ContentPage
    {     
        public MainPage()
        {
            InitializeComponent();

            // To use tree map control in code behind use the below code.

            //PopulationViewModel viewModel = new PopulationViewModel();

            //SfTreeMap treeMap = new SfTreeMap();
            //treeMap.BackgroundColor = Color.White;
            //treeMap.ColorValuePath = "Growth";
            //treeMap.WeightValuePath = "Population";
            //treeMap.LayoutType = LayoutTypes.Squarified;
            //treeMap.ShowTooltip = true;

            //LeafItemSettings leafSetting = new LeafItemSettings();
            //leafSetting.Gap = 2;
            //leafSetting.OverflowMode = LabelOverflowMode.Wrap;
            //leafSetting.BorderColor = Color.FromHex("#A9D9F7");
            //leafSetting.LabelPath = "Country";
            //treeMap.LeafItemSettings = leafSetting;

            //TreeMapFlatLevel flatLevel = new TreeMapFlatLevel();
            //flatLevel.HeaderHeight = 20;
            //flatLevel.GroupPath = "Continent";
            //flatLevel.GroupGap = 5;
            //flatLevel.ShowHeader = true;
            //flatLevel.HeaderStyle = new Syncfusion.SfTreeMap.XForms.Style() { Color = Color.Black };
            //treeMap.Levels.Add(flatLevel);

            //LegendSettings legendSettings = new LegendSettings();
            //legendSettings.ShowLegend = true;
            //legendSettings.Size = new Size(700, 45);
            //legendSettings.LabelStyle = new Syncfusion.SfTreeMap.XForms.Style() { Color = Color.Black };
            //treeMap.LegendSettings = legendSettings;

            //RangeColorMapping rangeColorMapping = new RangeColorMapping();

            //Range range1 = new Range();
            //range1.From = 0;
            //range1.To = 1;
            //range1.Color = Color.FromHex("#77D8D8");
            //range1.LegendLabel = "1 % Growth";

            //Range range2 = new Range();
            //range2.From = 0;
            //range2.To = 2;
            //range2.Color = Color.FromHex("#AED960");
            //range2.LegendLabel = "2 % Growth";

            //Range range3 = new Range();
            //range3.From = 0;
            //range3.To = 3;
            //range3.Color = Color.FromHex("#FFAF51");
            //range3.LegendLabel = "3 % Growth";

            //Range range4 = new Range();
            //range4.From = 0;
            //range4.To = 4;
            //range4.Color = Color.FromHex("#F3D240");
            //range4.LegendLabel = "4 % Growth";

            //rangeColorMapping.Ranges.Add(range1);
            //rangeColorMapping.Ranges.Add(range2);
            //rangeColorMapping.Ranges.Add(range3);
            //rangeColorMapping.Ranges.Add(range4);

            //treeMap.LeafItemColorMapping = rangeColorMapping;

            //treeMap.DataSource = viewModel.PopulationDetails;
            //this.Content = treeMap;


        }
    }

    public class PopulationViewModel
    {
        public PopulationViewModel()
        {
            this.PopulationDetails = new ObservableCollection<PopulationDetail>();
            PopulationDetails.Add(new PopulationDetail() { Continent = "Asia", Country = "Indonesia", Growth = 3, Population = 237641326 });
            PopulationDetails.Add(new PopulationDetail() { Continent = "Asia", Country = "Russia", Growth = 2, Population = 152518015 });
            PopulationDetails.Add(new PopulationDetail() { Continent = "Asia", Country = "Malaysia", Growth = 1, Population = 29672000 });
            PopulationDetails.Add(new PopulationDetail() { Continent = "North America", Country = "United States", Growth = 4, Population = 315645000 });
            PopulationDetails.Add(new PopulationDetail() { Continent = "North America", Country = "Mexico", Growth = 2, Population = 112336538 });
            PopulationDetails.Add(new PopulationDetail() { Continent = "North America", Country = "Canada", Growth = 1, Population = 35056064 });
            PopulationDetails.Add(new PopulationDetail() { Continent = "South America", Country = "Colombia", Growth = 1, Population = 47000000 });
            PopulationDetails.Add(new PopulationDetail() { Continent = "South America", Country = "Brazil", Growth = 3, Population = 193946886 });
            PopulationDetails.Add(new PopulationDetail() { Continent = "Africa", Country = "Nigeria", Growth = 2, Population = 170901000 });
            PopulationDetails.Add(new PopulationDetail() { Continent = "Africa", Country = "Egypt", Growth = 1, Population = 83661000 });
            PopulationDetails.Add(new PopulationDetail() { Continent = "Europe", Country = "Germany", Growth = 1, Population = 81993000 });
            PopulationDetails.Add(new PopulationDetail() { Continent = "Europe", Country = "France", Growth = 1, Population = 65605000 });
            PopulationDetails.Add(new PopulationDetail() { Continent = "Europe", Country = "UK", Growth = 1, Population = 63181775 });
        }

        public ObservableCollection<PopulationDetail> PopulationDetails
        {
            get;
            set;
        }
    }

    public class PopulationDetail
    {
        public string Continent { get; set; }
        public string Country { get; set; }
        public double Growth { get; set; }
        public double Population { get; set; }
    }

}
