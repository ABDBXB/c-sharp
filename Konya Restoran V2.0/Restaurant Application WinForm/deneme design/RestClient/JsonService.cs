using deneme_design.Cards;
using deneme_design.Context;
using deneme_design.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme_design.RestClient
{
    class JsonService
    {
        private  Employee employee { get; set; }
        private  ApiClient client = new ApiClient();

        public  Table GetTableById(long tableId)
        {
            return  JsonConvert.DeserializeObject<Table>(client.GetRequest("tables/" + tableId)); 
        }

        public long AddTable(TableContext tableContext)
        {
            return long.Parse(client.PostMethodTable("tables/add", tableContext));
        }

        public List<Table> getTableList()
        {
            return JsonConvert.DeserializeObject<List<Table>>(client.GetRequest("tables/"));
        }

        public List<CategoryContext> GetCategoryContexts()
        {
            return JsonConvert.DeserializeObject<List<CategoryContext>>(client.GetRequest("category/getall"));
        }

        public long DeleteFoodItem(long id)
        {
            return long.Parse(client.DeleteRequest("item/" + id));
        }
        // get FoodItemByCategory ID
        public  List<FoodItem> GetItemListByCategoryId(long id)
        {
            return (JsonConvert.DeserializeObject<Category>(client.GetRequest("category/" + id))).foodItemList; ;
        }

        public string GetCategoryByItemId(long id)
        {
            return client.GetRequest("item/fooditem/" + id);
        }

        public List<Category> GetCategoriesList()
        {
            return JsonConvert.DeserializeObject<List<Category>>(client.GetRequest("category/"));
        }
        public string AddNewEmployee(Employee employee)
        {
            return client.PostMethodEmployee("employee/add", employee);
        }
        public FoodItem GetFoodItemById(long id)
        {
            return JsonConvert.DeserializeObject<FoodItem>(client.GetRequest("item/" + id));
        }
        
        // Get all FoodItemList
        public  List<FoodItem> GetItemList()
        {
            string result = client.GetRequest("item/");
            if(result != null)
                return JsonConvert.DeserializeObject<List<FoodItem>>(result);
            
            return null;
        }

        public List<FoodItem> GetItemListByName(string name)
        {
            if(name.Length == 0)
                return GetItemList();

            else
            {
                string result = client.GetRequest("item/name/" + name);
                if (result != null && !result.Equals("Connection Error"))
                    return JsonConvert.DeserializeObject<List<FoodItem>>(result);
                
                return null;
            }   
        }
        public long DeleteEmployee(long empId)
        {
            return long.Parse(client.DeleteRequest("employee/delete/" + empId));
        }

        public List<Employee> GetEmployees()
        {
            return JsonConvert.DeserializeObject<List<Employee>>(client.GetRequest("employee/"));
        }

        public Order OpenOrder(long tableId)
        {
            long orderId = long.Parse(client.GetRequest("order/open/" + tableId));        
            return JsonConvert.DeserializeObject<Order>(client.GetRequest("order/" + orderId));
        }

        public long CloseOrder(long orderId)
        { 
            return long.Parse(client.PutRequest("order/" + orderId, null));
        }

        public  long SaveOrder(List<ItemContext> itemList, long orderId)
        {
            FoodOrderContext foodOrderContext = new FoodOrderContext(
                    orderId,
                    itemList,
                    ApiClient.employeeProfile.id
                );
            return long.Parse(client.PostMethod("item_order/addlist", foodOrderContext));
        }

        public long GetOrderId(long tableId)
        {
            return long.Parse(client.GetRequest("order/active/" + tableId.ToString()));
        }
    
        public List<long> UpdateFoodItemPortions(List<FoodItem_PortionContext> contexts)
        {
            return JsonConvert.DeserializeObject<List<long>>(client.PostMethodFoodItemPortionContext("item_portion/update", contexts));
        }

        public Order getOrderById(long tableId)
        {
            return JsonConvert.DeserializeObject<Order>(client.GetRequest("order/" + GetOrderId(tableId)));
        }

        public long DeleteFoodItemOrder(long id)
        {
            return long.Parse(client.DeleteRequest("item_order/delete/" + id));
        }
        public long DeleteFoodItemPortion(long id)
        {
            return long.Parse(client.DeleteRequest("item_portion/delete/" + id));
        }

        public long deleteTableById(long tableId)
        {
            return long.Parse(client.DeleteRequest("tables/" + tableId));
        }
    
        public  List<FoodItem_Portion> GetPortionListByFoodItemId(long foodItemId)
        {
            return   JsonConvert.DeserializeObject<List<FoodItem_Portion>>(client.GetRequest("item_portion/foodItem/" + foodItemId));
        }

        public List<Portion> GetPortionList()
        {
            return JsonConvert.DeserializeObject<List<Portion>>(client.GetRequest("portion/"));
        }

        public long UpdateFoodItemOrder(FoodOrderContext foodOrderContext, long orderId)
        {
            return long.Parse(client.PutRequest("item_order/" + orderId, foodOrderContext));
        }

        public async Task<long> UploadImage(Image image, string imageName)
        {
            return await client.UploadImage(image, imageName);
        }

        public long UpdateEmployeeProfile(Employee employee)
        {
            return long.Parse(client.PutRequestEmployee("employee/update", employee));
        }
        public  Image DownloadImage(long id)
        {
            ItemImages image =  JsonConvert.DeserializeObject<ItemImages>(client.GetRequest("image/" + id));
            MemoryStream ms = new MemoryStream(image.picture);
            return  Image.FromStream(ms);
        }

        public  string saveFoodItems(FoodItemContext foodItemContext)
        {
            return  client.PostMethodfood("item_portion/", foodItemContext);
        }

        public long UpdateFoodItemDetails(ItemContext itemContext)
        {
            return long.Parse(client.PutRequestFoodItem("item/update_details", itemContext));
        }
    }
}
