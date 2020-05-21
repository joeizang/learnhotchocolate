using HotChocolate.Types;

namespace learnhotchocolate.Schema
{
    public class MutationType : ObjectType<Mutation>
    {
        protected override void Configure(IObjectTypeDescriptor<Mutation> descriptor)
        {
            base.Configure(descriptor);
            descriptor.Field(x => x.CreateIncome(default!, default!))
            //.Argument("IncomeInputModel", i => i.Type<NonNullType<IncomeInputModelType>>())
            .Type<NonNullType<IncomeType>>();
            descriptor.Field(x => x.UpdateIncome(default!, default!))
            //.Argument("IncomeUpdateModel", i => i.Type<NonNullType<IncomeUpdateModelType>>())
            .Type<NonNullType<IncomeType>>();
            descriptor.Field(x => x.DeleteIncome(default!, default!))
            //.Argument("IncomeDeleteModel", i => i.Type<NonNullType<IncomeDeleteModelType>>())
            .Type<NonNullType<IncomeType>>();
        }
    }
}