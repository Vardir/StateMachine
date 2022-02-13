using System;

namespace Vardirsoft.StateMachine.Abstractions
{
  /// <summary>
  /// Base interface for transition handler implementations used to control execution flow during state machine execution.
  /// </summary>
  /// <typeparam name="TStateLabel">A type of state label used for transitions between states during state machine execution</typeparam>
  /// <typeparam name="TStateObject">A type of state object to use as contextual information during state machine execution</typeparam>
  public interface ITransitionHandler<in TStateLabel, in TStateObject>
    where TStateLabel: IEquatable<TStateLabel>, IComparable, IComparable<TStateLabel>
  {
    /// <summary>
    /// Handles the transition between the two states.
    /// Return value controls if the transition can be finished and thus the next <see cref="IStateHandler{TStateLabel,TStateObject}"/> executed
    /// or the state machine execution flow should be terminated.
    /// </summary>
    /// <param name="exitLabel">A state from which the transition happens</param>
    /// <param name="enteringLabel">A state to which the transition happens</param>
    /// <param name="state">A state object to use as contextual information. Typically, this object should not be changed</param>
    /// <returns>A value that controls whether to continue execution or to terminate state machine</returns>
    bool Handle(TStateLabel exitLabel, TStateLabel enteringLabel, TStateObject state);
  }
}