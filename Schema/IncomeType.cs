using HotChocolate.Types;
using learnhotchocolate.Models;

namespace learnhotchocolate.Schema
{
    public class IncomeType : ObjectType<Income>
    {
        protected override void Configure(IObjectTypeDescriptor<Income> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(i => i.Amount)
                .Type<NonNullType<DecimalType>>();
            descriptor.Field(i => i.Description)
                .Type<StringType>();
            descriptor.Field(i => i.Id)
                .Type<NonNullType<StringType>>();
            descriptor.Field(i => i.IncomeDate)
                .Type<NonNullType<DateTimeType>>();
            descriptor.Field(i => i.IncomeCategoryId)
                .Type<StringType>();
            descriptor.Field(i => i.IncomeSourceId)
                .Type<StringType>();
            descriptor.Field(i => i.IncomeCategory)
                .Type<IncomeCategoryType>();
            descriptor.Field(i => i.IncomeSource)
                .Type<IncomeSourceType>();
            descriptor.Field(x => x.CreatedAt)
                .Type<DateTimeType>();
            descriptor.Field(x => x.UpdatedAt)
                .Type<DateTimeType>();
        }
    }
}