using DevExpress.Xpf.Bars;
using DevExpress.Xpf.RichEdit;
using DevExpress.XtraRichEdit.API.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace WpfApplication1 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow()
        {
            InitializeComponent();

            richEdit.MailMergeOptions.DataSource = Data.DataHelper.GetDummyData();
            richEdit.MailMergeOptions.ViewMergedData = true;
            object firstDataSourceItem = (richEdit.MailMergeOptions.DataSource as System.Collections.IList)[0];
            InitializeInsertMergeBarItem(firstDataSourceItem);

        }

        private void InitializeInsertMergeBarItem(object firstDataSourceItem)
        {
            List<MergeFieldName> result = new List<MergeFieldName>();
            CalculateAllowedFieldsNames(result, "", btCustomInsertMergeField, firstDataSourceItem.GetType());
        }

        void CalculateAllowedFieldsNames(List<MergeFieldName> mmFields, string parentPropertyName, BarSubItem parentItem, Type currenType)
        {
            PropertyInfo[] properties = currenType.GetProperties();
            foreach (PropertyInfo propInfo in properties)
            {
                Type propertyType = propInfo.PropertyType;
                string df = parentPropertyName == "" ? propInfo.Name : parentPropertyName + "." + propInfo.Name;
                if (propertyType.Equals(typeof(System.Collections.IList)))
                    continue;
                if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition().Equals(typeof(System.Collections.Generic.List<>)))
                    continue;

                if (propertyType.Equals(typeof(string)) ||
                    propertyType.Equals(typeof(DateTime)) ||
                    propertyType.Equals(typeof(bool)) ||
                    propertyType.Equals(typeof(decimal)) ||
                    propertyType.Equals(typeof(int)))
                {
                    CreateBarButtonItem(parentItem, df, propInfo.Name);
                }
                else
                {
                    BarSubItem subItem = new BarSubItem();
                    subItem.Content = propInfo.Name;
                    parentItem.Items.Add(subItem);
                    CalculateAllowedFieldsNames(mmFields, df, subItem, propertyType);
                }
            }
        }

        private void CreateBarButtonItem(BarSubItem parentItem, string name, string displayName)
        {
            BarButtonItem item = new BarButtonItem();
            item.ItemClick += Item_ItemClick;
           
            item.Content = displayName;
            item.Tag = name;
            parentItem.Items.Add(item);
        }

        private void Item_ItemClick(object sender, ItemClickEventArgs e)
        {
            BarButtonItem item = sender as BarButtonItem;
            if (item.Tag == null)
                return;
            string fieldName = (string)item.Tag;
            Field mergeField = richEdit.Document.Fields.Create(richEdit.Document.CaretPosition, string.Format("MERGEFIELD \"{0}\"", fieldName));
            mergeField.Update();
        }

      
    }
}
