# Load Data from Different Data Sources into WPF Charts

The [Syncfusion WPF Charts](https://help.syncfusion.com/wpf/charts/getting-started) is optimized to visualize a huge volume of data elegantly. Its rich feature set includes functionalities like data binding, multiple axes, legends, animations, data labels, annotations, trackballs, tooltips, gradients, technical indicators, zooming, and more.

In this article, we’ll see how to load data from different data sources in the WPF Charts control. 

There are three essential properties of the WPF Charts to configure the data:

[ItemsSource](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartSeriesBase.html#Syncfusion_UI_Xaml_Charts_ChartSeriesBase_ItemsSource): Collects the data points used to generate the chart.

[XBindingPath](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartSeriesBase.html#Syncfusion_UI_Xaml_Charts_ChartSeriesBase_XBindingPath): A bindable property that gets the property path of x-axis data in ItemsSource to render the chart series.

[YBindingPath](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.XyDataSeries.html#Syncfusion_UI_Xaml_Charts_XyDataSeries_YBindingPath): A bindable property that gets the property path of y-axis data in ItemsSource to render the chart series.

## Key data sources
Syncfusion WPF Charts offers over 45 chart types. All the chart types support loading data from the following data sources:

* IEnumerable
* DataTable
* Array
* SQL
* JSON
* CSV

For a detailed, step-by-step guide on  how to load different data from various data sources in WPF Charts, refer to the comprehensive blog titled [Seamlessly Load Data from Different Data Sources into WPF Charts](https://www.syncfusion.com/blogs/post/different-data-source-wpf-charts).

## Troubleshooting
### Path too long exception
If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.