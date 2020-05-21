using HotChocolate.Types;

namespace learnhotchocolate.Schema
{
    public class IncomeSourceInputModel
    {
        public string Name { get; set; } = "";
        public string? PhoneNumber { get; set; }
    }

    public class IncomeSourceInputModelType : ObjectType<IncomeSourceInputModel>
    {
        protected override void Configure(IObjectTypeDescriptor<IncomeSourceInputModel> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(x => x.Name)
            .Type<NonNullType<StringType>>();
            descriptor.Field(x => x.PhoneNumber)
            .Type<StringType>();
        }
    }
}