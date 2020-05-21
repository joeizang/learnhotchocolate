using HotChocolate.Types;

namespace learnhotchocolate.Schema
{
    public class IncomeCategoryInputModel
    {
        public string CategoryName { get; set; } = "";
    }

    public class IncomeCategoryInputModelType : ObjectType<IncomeCategoryInputModel>
    {
        protected override void Configure(IObjectTypeDescriptor<IncomeCategoryInputModel> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(x => x.CategoryName)
            .Type<NonNullType<StringType>>();
        }
    }
}