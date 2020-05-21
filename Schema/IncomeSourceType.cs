using HotChocolate.Types;
using learnhotchocolate.Models;

namespace learnhotchocolate.Schema
{
    public class IncomeSourceType : ObjectType<IncomeSource>
    {
        protected override void Configure(IObjectTypeDescriptor<IncomeSource> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(ins => ins.Id)
                .Type<NonNullType<StringType>>();
            descriptor.Field(ins => ins.Name)
                .Type<StringType>();
            descriptor.Field(ins => ins.PhoneNumber)
                .Type<StringType>();
            descriptor.Field(ins => ins.CreatedAt)
                .Type<NonNullType<DateTimeType>>();
            descriptor.Field(ins => ins.UpdatedAt)
                .Type<NonNullType<DateTimeType>>();
        }
    }
}