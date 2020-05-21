using HotChocolate.Types;
using learnhotchocolate.Models;

namespace learnhotchocolate.Schema
{
    public class IncomeCategoryType : ObjectType<IncomeCategory>
    {
        protected override void Configure(IObjectTypeDescriptor<IncomeCategory> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(x => x.Id)
                .Type<NonNullType<StringType>>();
            descriptor.Field(x => x.IncomeCategoryName)
                .Type<NonNullType<StringType>>();
            descriptor.Field(x => x.Incomes)
                .Type<ListType<IncomeType>>();
            descriptor.Field(x => x.CreatedAt)
                .Type<DateTimeType>();
            descriptor.Field(x => x.UpdatedAt)
                .Type<DateTimeType>();
        }
    }
}