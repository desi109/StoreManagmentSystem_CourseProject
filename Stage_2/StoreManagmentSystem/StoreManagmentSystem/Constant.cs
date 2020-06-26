using System;

namespace StoreManagmentSystem
{
    public class Constant
    {
        public const String DATA_PATH_ITEMS = @"..\..\Data\Items.xml";
        public const String DATA_PATH_DELETED_ITEMS = @"..\..\Data\DeletedItems.xml";
        public const String DATA_PATH_PEOPLE = @"..\..\Data\People.xml";
        public const String DATA_PATH_DELETED_PEOPLE = @"..\..\Data\DeletedPeople.xml";
        public const String DATA_PATH_PRODUCTS = @"..\..\Data\Products.xml";
        public const String DATA_PATH_DELETED_PRODUCTS = @"..\..\Data\DeletedProducts.xml";
        public const String DATA_PATH_IDS = @"..\..\Data\Ids.xml";

        public static bool IS_EMPLOYEE_NEW = false;
        public static bool IS_BUYER_NEW = false;
        public static bool IS_PRODUCT_NEW = false;
    }
}
