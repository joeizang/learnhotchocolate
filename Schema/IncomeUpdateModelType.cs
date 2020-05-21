using HotChocolate.Types;

namespace learnhotchocolate.Schema
{
    public class IncomeUpdateModelType : ObjectType<IncomeUpdateModel>
    {
        protected override void Configure(IObjectTypeDescriptor<IncomeUpdateModel> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(x => x.IncomeId)
            .Type<NonNullType<StringType>>();
            descriptor.Field(x => x.Amount)
            .Type<NonNullType<DecimalType>>();
            descriptor.Field(x => x.Date)
            .Type<NonNullType<DateTimeType>>();
            descriptor.Field(x => x.Description)
            .Type<NonNullType<StringType>>();
            descriptor.Field(x => x.CategoryModel)
            .Type<NonNullType<IncomeCategoryInputModelType>>();
            descriptor.Field(x => x.SourceModel)
            .Type<NonNullType<IncomeSourceInputModelType>>();
        }
    }
}