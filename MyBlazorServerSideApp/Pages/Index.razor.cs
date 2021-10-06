using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MyBlazorServerSideApp.DataServices;

namespace MyBlazorServerSideApp.Pages
{
    public partial class Index : ComponentBase
    {
        [Parameter] public string MyParameter { get; set; }
        private string Test1;
        private string Test2;
        private List<MyDataStructure> _data;


        protected override async void OnInitialized()
        {
            var tmp = MyParameter;
            _data = _myDataService.GetData();
        }

        protected override async void OnParametersSet()
        {
            var tmp = MyParameter;
        }

        protected override async void OnAfterRender(bool firstRender)
        {
            await Log("OnAfterRender" + firstRender.ToString());
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
            Test2 = await _localStorage.GetItemAsync<string>("testkey");
        }
        void OnClick1()
        {

            StateHasChanged();
            //Test1 = "TEST";
            //Test1 = "EEN";
            //Test2 = "TWEE";

            _navigationManager.NavigateTo("page2",true);
        }

        async Task Log(string info)
        {
            await _jsRuntime.InvokeAsync<string>("console.log", info);
        }
        void OnChange(string value, string name)
        {
            Test1 = value;
        }
    }
}
