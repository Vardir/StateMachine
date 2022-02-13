using System;

namespace Vardirsoft.StateMachine.Abstractions
{
  /// <summary>
  /// Base interface for state handler implementations used to control state object or to execute external actions during state machine execution.
  /// </summary>
  /// <typeparam name="TStateLabel">A type of state label used for transitions between states during state machine execution</typeparam>
  /// <typeparam name="TStateObject">A type of state object to use as contextual information during state machine execution</typeparam>
  public interface IStateHandler<in TStateLabel, in TStateObject>
    where TStateLabel: IEquatable<TStateLabel>, IComparable, IComparable<TStateLabel>
  {
    /// <summary>
    /// Handles the new state after transition from the previous state. Used to manipulate the state object.
    /// </summary>
    /// <param name="label">A state label just entered</param>
    /// <param name="state">A state object to use as contextual information</param>
    void Handle(TStateLabel label, TStateObject state);
  }
}