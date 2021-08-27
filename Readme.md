<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128607832/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T590736)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomClasses.cs](./CS/WpfApplication1/Data/CustomClasses.cs) (VB: [CustomClasses.vb](./VB/WpfApplication1/Data/CustomClasses.vb))
* [DataHelper.cs](./CS/WpfApplication1/Data/DataHelper.cs) (VB: [DataHelper.vb](./VB/WpfApplication1/Data/DataHelper.vb))
* [MainWindow.xaml](./CS/WpfApplication1/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication1/MainWindow.xaml))
* **[MainWindow.xaml.cs](./CS/WpfApplication1/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication1/MainWindow.xaml.vb))**
<!-- default file list end -->
# How to replace the built-in "Insert Merge Field" menu item with a custom one to display the referenced object's properties


This example illustrates how to customize the "Insert Merge Field" menu to display the referenced object's properties with  sub menus. To accomplish this task, it is necessary to replace the built-in InsertMergeFieldItem with a custom one. After a bar item for the nested object's property is clicked, a <a href="https://documentation.devexpress.com/WPF/10303/Controls-and-Libraries/Rich-Text-Editor/Fields/Field-Codes/MERGEFIELD">MERGEFIELD</a> field is created for this property and inserted at the caret position.<br><br>See also: <a href="https://www.devexpress.com/Support/Center/p/T532297">How to customize the merge field collection and perform Mail Merge using the IList data source</a>

<br/>


