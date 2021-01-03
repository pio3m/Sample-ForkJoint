namespace ForkJoint.Api.Components.Activities
{
    using System;
    using Contracts;


    public interface DressBurgerArguments
    {
        Guid OrderId { get; }

        BurgerPatty Patty { get; }

        bool Lettuce { get; }
        bool Pickle { get; }
        bool Onion { get; }
        bool Ketchup { get; }
        bool Mustard { get; }
    }
}