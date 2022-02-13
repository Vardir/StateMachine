using System;

namespace Vardirsoft.StateMachine.Abstractions.Factories
{
  /// <summary>
  /// Base interface for state machine factories.
  /// </summary>
  /// <typeparam name="TStateLabel">A type of state label used for transitions between states during state machine execution</typeparam>
  /// <typeparam name="TStateObject">A type of state object to use as contextual information during state machine execution</typeparam>
  /// <remarks>For state label use any type that implements <see cref="IEquatable{T}"/> and <see cref="IComparable"/>. Best choice is enum type.</remarks>
  public interface IStateMachineFactory<in TStateLabel, in TStateObject>
    where TStateLabel: IEquatable<TStateLabel>, IComparable, IComparable<TStateLabel>
  {
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    IStateMachine<TStateLabel, TStateObject> Create();
  }
}