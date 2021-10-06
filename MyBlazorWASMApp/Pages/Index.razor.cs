using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using MyBlazorWASMApp.DataServices;

namespace MyBlazorWASMApp.Pages
{
    public partial class Index : ComponentBase
    {
        [Parameter] public string MyParameter { get; set; }
        private string Test1;
        private string Test2;
        private List<MyDataStructure> _data;


        protected override void OnInitialized()
        {
            var tmp = MyParameter;
            _data = _myDataService.GetData();
        }

        protected override void OnParametersSet()
        {
            var tmp = MyParameter;
        }

        protected override void OnAfterRender(bool firstRender)
        {

        }

        void OnChangeDropdown(object id)
        {
        }

        void OnTestData()
        {
            _data = _myDataService.GetData();
            Test2 = _data[1].FirstName;
        }

        async Task OnUpdateData()
        {
            await _localStorage.SetItemAsync("testkey", Test2);
            //_myDataService.UpdateData(new MyDataStructure
            //{
            //    FirstName = Test2
            //});
        }

        async Task OnReadData()
        {
            Test2 = await _localStorage.GetItemAsStringAsync("testkey");
        }
        void OnClick1()
        {

            StateHasChanged();
            //Test1 = "TEST";
            //Test1 = "EEN";
            //Test2 = "TWEE";

            _navigationManager.NavigateTo("page2");
        }

        void OnChange(string value, string name)
        {
            Test1 = value;
        }


    }
}
