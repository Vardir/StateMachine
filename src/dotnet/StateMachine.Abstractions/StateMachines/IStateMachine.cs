using System;

namespace Vardirsoft.StateMachine.Abstractions
{
  /// <summary>
  /// Base interface for state machine implementations.
  /// Typically you do not need to implement this interface directly.
  /// </summary>
  /// <typeparam name="TStateLabel">A type of state label used for transitions between states during state machine execution</typeparam>
  /// <typeparam name="TStateObject">A type of state object to use as contextual information during state machine execution</typeparam>
  public interface IStateMachine<in TStateLabel, in TStateObject>
    where TStateLabel: IEquatable<TStateLabel>, IComparable, IComparable<TStateLabel>
  {
    /// <summary>
    /// Initiates state machine execution using the provisioned state object as context and starting from the given state.
    /// </summary>
    /// <param name="label">A state label to start with</param>
    /// <param name="state">A state object to use as contextual information</param>
    void Enter(TStateLabel label, TStateObject state);
  }
}