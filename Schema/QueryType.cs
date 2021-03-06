using HotChocolate.Types;

namespace learnhotchocolate.Schema
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(inv => inv.Incomes(default!))
                .UseFiltering()
                .Type<NonNullType<ListType<IncomeType>>>();
            descriptor.Field(inv => inv.GetIncomeById(default!, default!))
                .Argument("id", x => x.Type<NonNullType<StringType>>());
            descriptor.Field(inc => inc.IncomeCategories(default!))
                .Type<NonNullType<ListType<IncomeCategoryType>>>();
        }
    }
}