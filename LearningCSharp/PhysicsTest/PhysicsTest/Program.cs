using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

namespace PhysicsSimulation;

public static class Units
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Length Meters(double value)
    {
        return new Length(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Time Seconds(double value)
    {
        return new Time(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Mass Kilograms(double value)
    {
        return new Mass(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Velocity MetersPerSecond(double value)
    {
        return new Velocity(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Acceleration MetersPerSecondSquared(double value)
    {
        return new Acceleration(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Force Newtons(double value)
    {
        return new Force(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Damping Damping(double value)
    {
        return new Damping(value);
    }
}

internal static class UnitFormatting
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Format(double value, string unit, string? format, IFormatProvider? provider)
    {
        provider ??= CultureInfo.InvariantCulture;
        return string.Concat(value.ToString(format, provider), " ", unit);
    }
}

public readonly record struct Length : IFormattable
{
    public static Length Zero => new(0.0);

    public double Value { get; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Length(double value)
    {
        Value = value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Length operator +(Length left, Length right)
    {
        return new Length(left.Value + right.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Length operator -(Length left, Length right)
    {
        return new Length(left.Value - right.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Length operator -(Length value)
    {
        return new Length(-value.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Length operator *(Length value, double scalar)
    {
        return new Length(value.Value * scalar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Length operator *(double scalar, Length value)
    {
        return new Length(scalar * value.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Length operator /(Length value, double scalar)
    {
        return new Length(value.Value / scalar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Velocity operator /(Length length, Time time)
    {
        return new Velocity(length.Value / time.Value);
    }

    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        return UnitFormatting.Format(Value, "m", format, formatProvider);
    }

    public override string ToString()
    {
        return ToString(null, CultureInfo.InvariantCulture);
    }
}

public readonly record struct Time : IFormattable
{
    public static Time Zero => new(0.0);

    public double Value { get; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Time(double value)
    {
        Value = value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Time operator +(Time left, Time right)
    {
        return new Time(left.Value + right.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Time operator -(Time left, Time right)
    {
        return new Time(left.Value - right.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Time operator -(Time value)
    {
        return new Time(-value.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Time operator *(Time value, double scalar)
    {
        return new Time(value.Value * scalar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Time operator *(double scalar, Time value)
    {
        return new Time(scalar * value.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Time operator /(Time value, double scalar)
    {
        return new Time(value.Value / scalar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Length operator *(Time time, Velocity velocity)
    {
        return new Length(time.Value * velocity.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Velocity operator *(Time time, Acceleration acceleration)
    {
        return new Velocity(time.Value * acceleration.Value);
    }

    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        return UnitFormatting.Format(Value, "s", format, formatProvider);
    }

    public override string ToString()
    {
        return ToString(null, CultureInfo.InvariantCulture);
    }
}

public readonly record struct Mass : IFormattable
{
    public static Mass Zero => new(0.0);

    public double Value { get; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Mass(double value)
    {
        Value = value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Mass operator +(Mass left, Mass right)
    {
        return new Mass(left.Value + right.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Mass operator -(Mass left, Mass right)
    {
        return new Mass(left.Value - right.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Mass operator -(Mass value)
    {
        return new Mass(-value.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Mass operator *(Mass value, double scalar)
    {
        return new Mass(value.Value * scalar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Mass operator *(double scalar, Mass value)
    {
        return new Mass(scalar * value.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Mass operator /(Mass value, double scalar)
    {
        return new Mass(value.Value / scalar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Force operator *(Mass mass, Acceleration acceleration)
    {
        return new Force(mass.Value * acceleration.Value);
    }

    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        return UnitFormatting.Format(Value, "kg", format, formatProvider);
    }

    public override string ToString()
    {
        return ToString(null, CultureInfo.InvariantCulture);
    }
}

public readonly record struct Velocity : IFormattable
{
    public static Velocity Zero => new(0.0);

    public double Value { get; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Velocity(double value)
    {
        Value = value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Velocity operator +(Velocity left, Velocity right)
    {
        return new Velocity(left.Value + right.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Velocity operator -(Velocity left, Velocity right)
    {
        return new Velocity(left.Value - right.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Velocity operator -(Velocity value)
    {
        return new Velocity(-value.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Velocity operator *(Velocity value, double scalar)
    {
        return new Velocity(value.Value * scalar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Velocity operator *(double scalar, Velocity value)
    {
        return new Velocity(scalar * value.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Velocity operator /(Velocity value, double scalar)
    {
        return new Velocity(value.Value / scalar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Acceleration operator /(Velocity velocity, Time time)
    {
        return new Acceleration(velocity.Value / time.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Length operator *(Velocity velocity, Time time)
    {
        return new Length(velocity.Value * time.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Force operator *(Velocity velocity, Damping damping)
    {
        return new Force(velocity.Value * damping.Value);
    }

    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        return UnitFormatting.Format(Value, "m/s", format, formatProvider);
    }

    public override string ToString()
    {
        return ToString(null, CultureInfo.InvariantCulture);
    }
}

public readonly record struct Acceleration : IFormattable
{
    public static Acceleration Zero => new(0.0);

    public double Value { get; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Acceleration(double value)
    {
        Value = value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Acceleration operator +(Acceleration left, Acceleration right)
    {
        return new Acceleration(left.Value + right.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Acceleration operator -(Acceleration left, Acceleration right)
    {
        return new Acceleration(left.Value - right.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Acceleration operator -(Acceleration value)
    {
        return new Acceleration(-value.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Acceleration operator *(Acceleration value, double scalar)
    {
        return new Acceleration(value.Value * scalar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Acceleration operator *(double scalar, Acceleration value)
    {
        return new Acceleration(scalar * value.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Acceleration operator /(Acceleration value, double scalar)
    {
        return new Acceleration(value.Value / scalar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Velocity operator *(Acceleration acceleration, Time time)
    {
        return new Velocity(acceleration.Value * time.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Force operator *(Acceleration acceleration, Mass mass)
    {
        return new Force(acceleration.Value * mass.Value);
    }

    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        return UnitFormatting.Format(Value, "m/s^2", format, formatProvider);
    }

    public override string ToString()
    {
        return ToString(null, CultureInfo.InvariantCulture);
    }
}

public readonly record struct Force : IFormattable
{
    public static Force Zero => new(0.0);

    public double Value { get; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Force(double value)
    {
        Value = value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Force operator +(Force left, Force right)
    {
        return new Force(left.Value + right.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Force operator -(Force left, Force right)
    {
        return new Force(left.Value - right.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Force operator -(Force value)
    {
        return new Force(-value.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Force operator *(Force value, double scalar)
    {
        return new Force(value.Value * scalar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Force operator *(double scalar, Force value)
    {
        return new Force(scalar * value.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Force operator /(Force value, double scalar)
    {
        return new Force(value.Value / scalar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Acceleration operator /(Force force, Mass mass)
    {
        return new Acceleration(force.Value / mass.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Velocity operator /(Force force, Damping damping)
    {
        return new Velocity(force.Value / damping.Value);
    }

    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        return UnitFormatting.Format(Value, "N", format, formatProvider);
    }

    public override string ToString()
    {
        return ToString(null, CultureInfo.InvariantCulture);
    }
}

public readonly record struct Damping : IFormattable
{
    public static Damping Zero => new(0.0);

    public double Value { get; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Damping(double value)
    {
        Value = value;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Damping operator +(Damping left, Damping right)
    {
        return new Damping(left.Value + right.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Damping operator -(Damping left, Damping right)
    {
        return new Damping(left.Value - right.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Damping operator -(Damping value)
    {
        return new Damping(-value.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Damping operator *(Damping value, double scalar)
    {
        return new Damping(value.Value * scalar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Damping operator *(double scalar, Damping value)
    {
        return new Damping(scalar * value.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Damping operator /(Damping value, double scalar)
    {
        return new Damping(value.Value / scalar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Force operator *(Damping damping, Velocity velocity)
    {
        return new Force(damping.Value * velocity.Value);
    }

    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        return UnitFormatting.Format(Value, "kg/s", format, formatProvider);
    }

    public override string ToString()
    {
        return ToString(null, CultureInfo.InvariantCulture);
    }
}

public interface IStateDerivative<TDerivative>
    where TDerivative : struct, IStateDerivative<TDerivative>
{
    TDerivative Plus(TDerivative rhs);
    TDerivative ScaleBy(double scalar);
}

public interface IOdeState<TState, TDerivative>
    where TState : struct, IOdeState<TState, TDerivative>
    where TDerivative : struct, IStateDerivative<TDerivative>
{
    TState ApplyDerivative(TDerivative derivative, Time timeStep);
}

public interface IOdeSystem<TState, TDerivative>
    where TState : struct, IOdeState<TState, TDerivative>
    where TDerivative : struct, IStateDerivative<TDerivative>
{
    TDerivative Derivative(Time time, TState state);
}

public readonly record struct MotionState : IOdeState<MotionState, MotionDerivative>
{
    public Length Position { get; }
    public Velocity Velocity { get; }

    public MotionState(Length position, Velocity velocity)
    {
        Position = position;
        Velocity = velocity;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static MotionState AtRest(Length position)
    {
        return new MotionState(position, Units.MetersPerSecond(0.0));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Length Height()
    {
        return Position;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Velocity SignedVelocity()
    {
        return Velocity;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Velocity Speed()
    {
        return new Velocity(Math.Abs(Velocity.Value));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public MotionState ApplyDerivative(MotionDerivative derivative, Time timeStep)
    {
        return new MotionState(
            Position + derivative.PositionDerivative * timeStep,
            Velocity + derivative.VelocityDerivative * timeStep);
    }
}

public readonly record struct MotionDerivative : IStateDerivative<MotionDerivative>
{
    public Velocity PositionDerivative { get; }
    public Acceleration VelocityDerivative { get; }

    public MotionDerivative(Velocity positionDerivative, Acceleration velocityDerivative)
    {
        PositionDerivative = positionDerivative;
        VelocityDerivative = velocityDerivative;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public MotionDerivative Plus(MotionDerivative rhs)
    {
        return new MotionDerivative(
            PositionDerivative + rhs.PositionDerivative,
            VelocityDerivative + rhs.VelocityDerivative);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public MotionDerivative ScaleBy(double scalar)
    {
        return new MotionDerivative(
            PositionDerivative * scalar,
            VelocityDerivative * scalar);
    }
}

public readonly record struct Sample<TState>(Time Time, TState State);

public sealed class Solution<TState>
{
    private readonly List<Sample<TState>> _samples;

    public Solution(IEnumerable<Sample<TState>> samples)
    {
        _samples = samples?.ToList() ?? throw new ArgumentNullException(nameof(samples));
    }

    public Solution(List<Sample<TState>> samples)
    {
        _samples = samples ?? throw new ArgumentNullException(nameof(samples));
    }

    public IReadOnlyList<Sample<TState>> Samples
    {
        get { return _samples; }
    }

    public int Count
    {
        get { return _samples.Count; }
    }

    public bool IsEmpty
    {
        get { return _samples.Count == 0; }
    }

    public Sample<TState>? First()
    {
        if (_samples.Count == 0)
        {
            return null;
        }

        return _samples[0];
    }

    public Sample<TState>? Last()
    {
        if (_samples.Count == 0)
        {
            return null;
        }

        return _samples[^1];
    }
}

public static class Rk4Integrator
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TState Step<TSystem, TState, TDerivative>(
        TSystem system,
        Time time,
        TState state,
        Time timeStep)
        where TSystem : IOdeSystem<TState, TDerivative>
        where TState : struct, IOdeState<TState, TDerivative>
        where TDerivative : struct, IStateDerivative<TDerivative>
    {
        var halfStep = timeStep * 0.5;

        var k1 = system.Derivative(time, state);
        var k2 = system.Derivative(time + halfStep, state.ApplyDerivative(k1, halfStep));
        var k3 = system.Derivative(time + halfStep, state.ApplyDerivative(k2, halfStep));
        var k4 = system.Derivative(time + timeStep, state.ApplyDerivative(k3, timeStep));

        var weightedDerivative = k1
            .Plus(k2.ScaleBy(2.0))
            .Plus(k3.ScaleBy(2.0))
            .Plus(k4)
            .ScaleBy(1.0 / 6.0);

        return state.ApplyDerivative(weightedDerivative, timeStep);
    }

    public static Solution<TState> Integrate<TSystem, TState, TDerivative>(
        TSystem system,
        Time initialTime,
        TState initialState,
        Time timeStep,
        int steps)
        where TSystem : IOdeSystem<TState, TDerivative>
        where TState : struct, IOdeState<TState, TDerivative>
        where TDerivative : struct, IStateDerivative<TDerivative>
    {
        if (timeStep.Value <= 0.0)
        {
            throw new ArgumentOutOfRangeException(nameof(timeStep), timeStep, "Time step must be greater than zero.");
        }

        if (steps < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(steps), steps, "Steps must be zero or greater.");
        }

        var samples = new List<Sample<TState>>(steps + 1);
        var time = initialTime;
        var state = initialState;

        samples.Add(new Sample<TState>(time, state));

        for (var i = 0; i < steps; i++)
        {
            state = Step<TSystem, TState, TDerivative>(system, time, state, timeStep);
            time = time + timeStep;
            samples.Add(new Sample<TState>(time, state));
        }

        return new Solution<TState>(samples);
    }
}

public sealed class SimulationTimelineException : Exception
{
    public SimulationTimelineException(string message)
        : base(message)
    {
    }
}

public readonly record struct SimulationTimeline
{
    public Time StartTime { get; }
    public Time TimeStep { get; }
    public int Steps { get; }

    private SimulationTimeline(Time startTime, Time timeStep, int steps)
    {
        StartTime = startTime;
        TimeStep = timeStep;
        Steps = steps;
    }

    public static SimulationTimeline FromStepCount(Time startTime, Time timeStep, int steps)
    {
        if (timeStep.Value <= 0.0)
        {
            throw new SimulationTimelineException($"Simulation time step must be greater than zero, got {timeStep}.");
        }

        if (steps <= 0)
        {
            throw new SimulationTimelineException("Simulation steps must be greater than zero.");
        }

        return new SimulationTimeline(startTime, timeStep, steps);
    }

    public static SimulationTimeline FromDuration(Time startTime, Time timeStep, Time duration)
    {
        if (timeStep.Value <= 0.0)
        {
            throw new SimulationTimelineException($"Simulation time step must be greater than zero, got {timeStep}.");
        }

        if (duration.Value < 0.0)
        {
            throw new SimulationTimelineException($"Simulation duration must be zero or greater, got {duration}.");
        }

        var steps = Math.Max((int)Math.Ceiling(duration.Value / timeStep.Value), 1);

        return new SimulationTimeline(startTime, timeStep, steps);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Time Duration()
    {
        return TimeStep * Steps;
    }
}

public sealed class FallingBodySystemException : Exception
{
    public FallingBodySystemException(string message)
        : base(message)
    {
    }
}

public readonly record struct FallingBodySystem : IOdeSystem<MotionState, MotionDerivative>
{
    public Mass Mass { get; }
    public Damping Damping { get; }
    public Acceleration Gravity { get; }

    public FallingBodySystem(Mass mass, Damping damping, Acceleration gravity)
    {
        if (mass.Value <= 0.0)
        {
            throw new FallingBodySystemException($"Mass must be greater than zero, got {mass}.");
        }

        if (damping.Value < 0.0)
        {
            throw new FallingBodySystemException($"Damping must be zero or greater, got {damping}.");
        }

        if (!double.IsFinite(gravity.Value))
        {
            throw new FallingBodySystemException($"Gravity must be finite, got {gravity}.");
        }

        Mass = mass;
        Damping = damping;
        Gravity = gravity;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Force GravityForce()
    {
        return Mass * Gravity;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Force DragForce(MotionState state)
    {
        return Damping * state.Velocity;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Force DragForceMagnitude(MotionState state)
    {
        return new Force(Math.Abs(DragForce(state).Value));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Force NetForce(MotionState state)
    {
        return GravityForce() - DragForce(state);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Acceleration Acceleration(MotionState state)
    {
        return NetForce(state) / Mass;
    }

    public Velocity? TerminalVelocity()
    {
        if (Damping.Value == 0.0)
        {
            return null;
        }

        return GravityForce() / Damping;
    }

    public FallingBodySimulation SimulateFromState(MotionState initialState, SimulationTimeline timeline)
    {
        var solution = Rk4Integrator.Integrate<FallingBodySystem, MotionState, MotionDerivative>(
            this,
            timeline.StartTime,
            initialState,
            timeline.TimeStep,
            timeline.Steps);

        return new FallingBodySimulation(this, timeline, initialState, solution);
    }

    public FallingBodySimulation SimulateDropFromRest(Length initialHeight, SimulationTimeline timeline)
    {
        return SimulateFromState(MotionState.AtRest(initialHeight), timeline);
    }

    public FallingBodySimulation SimulateDropFromHeight(
        Length initialHeight,
        Velocity initialVelocity,
        SimulationTimeline timeline)
    {
        return SimulateFromState(new MotionState(initialHeight, initialVelocity), timeline);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public MotionDerivative Derivative(Time time, MotionState state)
    {
        _ = time;
        return new MotionDerivative(state.Velocity, Acceleration(state));
    }
}

public sealed class FallingBodySimulation
{
    private readonly FallingBodySystem _system;
    private readonly SimulationTimeline _timeline;
    private readonly MotionState _initialState;
    private readonly Solution<MotionState> _solution;

    public FallingBodySimulation(
        FallingBodySystem system,
        SimulationTimeline timeline,
        MotionState initialState,
        Solution<MotionState> solution)
    {
        _system = system;
        _timeline = timeline;
        _initialState = initialState;
        _solution = solution ?? throw new ArgumentNullException(nameof(solution));
    }

    public FallingBodySystem System
    {
        get { return _system; }
    }

    public SimulationTimeline Timeline
    {
        get { return _timeline; }
    }

    public MotionState InitialState
    {
        get { return _initialState; }
    }

    public Length InitialHeight()
    {
        return _initialState.Height();
    }

    public Velocity InitialVelocity()
    {
        return _initialState.SignedVelocity();
    }

    public Velocity InitialSpeed()
    {
        return _initialState.Speed();
    }

    public Velocity? TerminalVelocity()
    {
        return _system.TerminalVelocity();
    }

    public IReadOnlyList<Sample<MotionState>> Samples
    {
        get { return _solution.Samples; }
    }

    public Sample<MotionState>? FirstSample()
    {
        return _solution.First();
    }

    public Sample<MotionState>? LastSample()
    {
        return _solution.Last();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Velocity SpeedAt(MotionState state)
    {
        return state.Speed();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Acceleration AccelerationAt(MotionState state)
    {
        return _system.Acceleration(state);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Force DragForceAt(MotionState state)
    {
        return _system.DragForce(state);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Force NetForceAt(MotionState state)
    {
        return _system.NetForce(state);
    }

    public Length? MaximumHeight()
    {
        if (Samples.Count == 0)
        {
            return null;
        }

        var maximum = Samples[0].State.Position;

        foreach (var sample in Samples)
        {
            if (sample.State.Position.Value > maximum.Value)
            {
                maximum = sample.State.Position;
            }
        }

        return maximum;
    }

    public Length? MinimumHeight()
    {
        if (Samples.Count == 0)
        {
            return null;
        }

        var minimum = Samples[0].State.Position;

        foreach (var sample in Samples)
        {
            if (sample.State.Position.Value < minimum.Value)
            {
                minimum = sample.State.Position;
            }
        }

        return minimum;
    }

    public Velocity? MaximumSpeed()
    {
        if (Samples.Count == 0)
        {
            return null;
        }

        var maximum = Samples[0].State.Speed();

        foreach (var sample in Samples)
        {
            var speed = sample.State.Speed();

            if (speed.Value > maximum.Value)
            {
                maximum = speed;
            }
        }

        return maximum;
    }

    public Time? TimeOfImpact()
    {
        var segment = FirstGroundCrossingSegment();

        if (segment is null)
        {
            return null;
        }

        var left = segment.Value.Left;
        var right = segment.Value.Right;

        if (left.Time.Value == right.Time.Value)
        {
            return left.Time;
        }

        var leftHeight = left.State.Position.Value;
        var rightHeight = right.State.Position.Value;
        var interpolation = leftHeight / (leftHeight - rightHeight);
        var impactTimeValue = left.Time.Value + interpolation * (right.Time.Value - left.Time.Value);

        return new Time(impactTimeValue);
    }

    public Velocity? ImpactVelocity()
    {
        var segment = FirstGroundCrossingSegment();

        if (segment is null)
        {
            return null;
        }

        var left = segment.Value.Left;
        var right = segment.Value.Right;

        if (left.Time.Value == right.Time.Value)
        {
            return left.State.Velocity;
        }

        var leftHeight = left.State.Position.Value;
        var rightHeight = right.State.Position.Value;
        var interpolation = leftHeight / (leftHeight - rightHeight);

        var impactVelocityValue =
            left.State.Velocity.Value + interpolation * (right.State.Velocity.Value - left.State.Velocity.Value);

        return new Velocity(impactVelocityValue);
    }

    public Velocity? ImpactSpeed()
    {
        var impactVelocity = ImpactVelocity();

        if (impactVelocity is null)
        {
            return null;
        }

        return new Velocity(Math.Abs(impactVelocity.Value.Value));
    }

    public MotionState? ImpactState()
    {
        var impactVelocity = ImpactVelocity();

        if (impactVelocity is null)
        {
            return null;
        }

        return new MotionState(Length.Zero, impactVelocity.Value);
    }

    public Sample<MotionState>? ImpactSample()
    {
        var impactTime = TimeOfImpact();
        var impactState = ImpactState();

        if (impactTime is null || impactState is null)
        {
            return null;
        }

        return new Sample<MotionState>(impactTime.Value, impactState.Value);
    }

    public IEnumerable<Sample<MotionState>> EveryNthSample(int step)
    {
        var clampedStep = Math.Max(step, 1);

        for (var index = 0; index < Samples.Count; index += clampedStep)
        {
            yield return Samples[index];
        }
    }

    public string DescribeSample(Sample<MotionState> sample)
    {
        var state = sample.State;
        var speed = SpeedAt(state);
        var acceleration = AccelerationAt(state);

        return FormattableString.Invariant(
            $"t = {sample.Time.Value,5:0.00} s | height = {state.Position.Value,9:0.0000} m | velocity = {state.Velocity.Value,9:0.0000} m/s | speed = {speed.Value,9:0.0000} m/s | acceleration = {acceleration.Value,9:0.0000} m/s^2");
    }

    public IReadOnlyList<string> SampleReportLinesEvery(int step)
    {
        var lines = new List<string>();

        foreach (var sample in EveryNthSample(step))
        {
            lines.Add(DescribeSample(sample));
        }

        return lines;
    }

    public string Summary()
    {
        var terminalVelocity = TerminalVelocity();

        return string.Join(
            Environment.NewLine,
            $"initial height = {InitialHeight()}",
            $"initial speed = {InitialSpeed()}",
            terminalVelocity is null
                ? "terminal velocity = undefined (zero damping)"
                : $"terminal velocity = {terminalVelocity.Value}");
    }

    private (Sample<MotionState> Left, Sample<MotionState> Right)? FirstGroundCrossingSegment()
    {
        if (Samples.Count < 2)
        {
            return null;
        }

        for (var i = 0; i < Samples.Count - 1; i++)
        {
            var left = Samples[i];
            var right = Samples[i + 1];

            var leftHeight = left.State.Position.Value;
            var rightHeight = right.State.Position.Value;

            if (leftHeight > 0.0 && rightHeight <= 0.0)
            {
                return (left, right);
            }

            if (leftHeight == 0.0)
            {
                return (left, left);
            }
        }

        return null;
    }
}

public sealed class BenchmarkScenario
{
    public string Name { get; }
    public int Iterations { get; }
    public Action Action { get; }

    public BenchmarkScenario(string name, int iterations, Action action)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Iterations = iterations > 0 ? iterations : throw new ArgumentOutOfRangeException(nameof(iterations));
        Action = action ?? throw new ArgumentNullException(nameof(action));
    }
}

public readonly record struct BenchmarkResult(
    string Name,
    int Iterations,
    TimeSpan TotalElapsed,
    double AverageNanoseconds,
    double OperationsPerSecond,
    long AllocatedBytes)
{
    public double AverageMicroseconds
    {
        get { return AverageNanoseconds / 1_000.0; }
    }

    public double AverageMilliseconds
    {
        get { return AverageNanoseconds / 1_000_000.0; }
    }
}

public static class BenchmarkFormatting
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string GroupLong(long value)
    {
        return GroupUnsigned((ulong)Math.Abs(value), value < 0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string GroupInt(int value)
    {
        return GroupUnsigned((ulong)Math.Abs((long)value), value < 0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string GroupDoubleAsInteger(double value)
    {
        var rounded = Math.Round(value, MidpointRounding.AwayFromZero);

        if (rounded > long.MaxValue)
        {
            return GroupUnsigned((ulong)rounded, false);
        }

        if (rounded < long.MinValue)
        {
            return GroupUnsigned((ulong)Math.Abs(rounded), true);
        }

        return GroupLong((long)rounded);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double BytesToMb(long bytes)
    {
        return bytes / 1_000_000.0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string GroupUnsigned(ulong value, bool isNegative)
    {
        var digits = value.ToString(CultureInfo.InvariantCulture);
        var result = new System.Text.StringBuilder(digits.Length + digits.Length / 3 + (isNegative ? 1 : 0));

        if (isNegative)
        {
            result.Append('-');
        }

        for (var index = 0; index < digits.Length; index++)
        {
            if (index > 0 && (digits.Length - index) % 3 == 0)
            {
                result.Append('.');
            }

            result.Append(digits[index]);
        }

        return result.ToString();
    }
}

public static class PerformanceHarness
{
    public static BenchmarkResult Run(BenchmarkScenario scenario)
    {
        if (scenario is null)
        {
            throw new ArgumentNullException(nameof(scenario));
        }

        for (var i = 0; i < Math.Min(16, scenario.Iterations); i++)
        {
            scenario.Action();
        }

        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        var beforeBytes = GC.GetAllocatedBytesForCurrentThread();
        var stopwatch = Stopwatch.StartNew();

        for (var i = 0; i < scenario.Iterations; i++)
        {
            scenario.Action();
        }

        stopwatch.Stop();
        var afterBytes = GC.GetAllocatedBytesForCurrentThread();

        var totalElapsed = stopwatch.Elapsed;
        var averageNanoseconds = totalElapsed.TotalMilliseconds * 1_000_000.0 / scenario.Iterations;
        var operationsPerSecond = scenario.Iterations / totalElapsed.TotalSeconds;
        var allocatedBytes = afterBytes - beforeBytes;

        return new BenchmarkResult(
            scenario.Name,
            scenario.Iterations,
            totalElapsed,
            averageNanoseconds,
            operationsPerSecond,
            allocatedBytes);
    }

    public static void Print(BenchmarkResult result)
    {
        Console.WriteLine($"name                : {result.Name}");
        Console.WriteLine($"iterations          : {BenchmarkFormatting.GroupInt(result.Iterations)}");
        Console.WriteLine($"total elapsed       : {result.TotalElapsed.TotalMilliseconds:0.000} ms");
        Console.WriteLine($"avg / iteration     : {result.AverageNanoseconds:0.000} ns");
        Console.WriteLine($"avg / iteration     : {result.AverageMicroseconds:0.000} µs");
        Console.WriteLine($"avg / iteration     : {result.AverageMilliseconds:0.000000} ms");
        Console.WriteLine($"ops / second        : {BenchmarkFormatting.GroupDoubleAsInteger(result.OperationsPerSecond)}");
        Console.WriteLine(
            $"allocated total     : {BenchmarkFormatting.BytesToMb(result.AllocatedBytes):0.000} MB ({BenchmarkFormatting.GroupLong(result.AllocatedBytes)} B)");
        Console.WriteLine(
            $"allocated / iter    : {BenchmarkFormatting.BytesToMb(result.AllocatedBytes) / result.Iterations:0.000000} MB ({(double)result.AllocatedBytes / result.Iterations:0.000} B)");
        Console.WriteLine();
    }
}

public static class Program
{
    public static int Main(string[] args)
    {
        try
        {
            if (HasBenchmarkFlag(args))
            {
                RunBenchmarks();
                return 0;
            }

            RunDemo();
            return 0;
        }
        catch (Exception exception)
        {
            Console.Error.WriteLine(exception);
            return 1;
        }
    }

    private static bool HasBenchmarkFlag(string[] args)
    {
        if (args is null || args.Length == 0)
        {
            return false;
        }

        foreach (var arg in args)
        {
            if (string.Equals(arg, "--benchmark", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(arg, "-b", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }

        return false;
    }

    private static void RunDemo()
    {
        var system = new FallingBodySystem(
            Units.Kilograms(80.0),
            Units.Damping(12.5),
            Units.MetersPerSecondSquared(-9.81));

        var timeline = SimulationTimeline.FromStepCount(
            Units.Seconds(0.0),
            Units.Seconds(0.05),
            steps: 200);

        var simulation = system.SimulateDropFromHeight(
            Units.Meters(100.0),
            Units.MetersPerSecond(0.0),
            timeline);

        Console.WriteLine(simulation.Summary());
        Console.WriteLine();

        foreach (var line in simulation.SampleReportLinesEvery(20))
        {
            Console.WriteLine(line);
        }

        Console.WriteLine();

        var maximumHeight = simulation.MaximumHeight();
        if (maximumHeight is not null)
        {
            Console.WriteLine($"maximum height = {maximumHeight.Value}");
        }

        var maximumSpeed = simulation.MaximumSpeed();
        if (maximumSpeed is not null)
        {
            Console.WriteLine($"maximum speed = {maximumSpeed.Value}");
        }

        var timeOfImpact = simulation.TimeOfImpact();
        if (timeOfImpact is not null)
        {
            Console.WriteLine($"time of impact = {timeOfImpact.Value}");
        }
        else
        {
            Console.WriteLine("time of impact = not reached during simulated time span");
        }

        var impactVelocity = simulation.ImpactVelocity();
        if (impactVelocity is not null)
        {
            Console.WriteLine($"impact velocity = {impactVelocity.Value}");
        }
        else
        {
            Console.WriteLine("impact velocity = not reached during simulated time span");
        }

        var impactSpeed = simulation.ImpactSpeed();
        if (impactSpeed is not null)
        {
            Console.WriteLine($"impact speed = {impactSpeed.Value}");
        }
        else
        {
            Console.WriteLine("impact speed = not reached during simulated time span");
        }
    }

    private static void RunBenchmarks()
    {
        Console.WriteLine("Run with: dotnet run -c Release -- --benchmark");
        Console.WriteLine();

        var system = new FallingBodySystem(
            Units.Kilograms(80.0),
            Units.Damping(12.5),
            Units.MetersPerSecondSquared(-9.81));

        var shortTimeline = SimulationTimeline.FromStepCount(
            Units.Seconds(0.0),
            Units.Seconds(0.05),
            steps: 200);

        var longTimeline = SimulationTimeline.FromStepCount(
            Units.Seconds(0.0),
            Units.Seconds(0.05),
            steps: 20_000);

        var initialState = new MotionState(
            Units.Meters(100.0),
            Units.MetersPerSecond(0.0));

        var prebuiltSimulation = system.SimulateDropFromHeight(
            Units.Meters(100.0),
            Units.MetersPerSecond(0.0),
            shortTimeline);

        var scenarios = new[]
        {
            new BenchmarkScenario(
                name: "RK4 single step",
                iterations: 1_000_000,
                action: static () =>
                {
                    var localSystem = new FallingBodySystem(
                        Units.Kilograms(80.0),
                        Units.Damping(12.5),
                        Units.MetersPerSecondSquared(-9.81));

                    var localInitialState = new MotionState(
                        Units.Meters(100.0),
                        Units.MetersPerSecond(0.0));

                    _ = Rk4Integrator.Step<FallingBodySystem, MotionState, MotionDerivative>(
                        localSystem,
                        Units.Seconds(0.0),
                        localInitialState,
                        Units.Seconds(0.05));
                }),

            new BenchmarkScenario(
                name: "Integrate 200 steps",
                iterations: 100_000,
                action: () =>
                {
                    _ = Rk4Integrator.Integrate<FallingBodySystem, MotionState, MotionDerivative>(
                        system,
                        shortTimeline.StartTime,
                        initialState,
                        shortTimeline.TimeStep,
                        shortTimeline.Steps);
                }),

            new BenchmarkScenario(
                name: "Integrate 20,000 steps",
                iterations: 1_000,
                action: () =>
                {
                    _ = Rk4Integrator.Integrate<FallingBodySystem, MotionState, MotionDerivative>(
                        system,
                        longTimeline.StartTime,
                        initialState,
                        longTimeline.TimeStep,
                        longTimeline.Steps);
                }),

            new BenchmarkScenario(
                name: "SimulateDropFromHeight",
                iterations: 100_000,
                action: () =>
                {
                    _ = system.SimulateDropFromHeight(
                        Units.Meters(100.0),
                        Units.MetersPerSecond(0.0),
                        shortTimeline);
                }),

            new BenchmarkScenario(
                name: "MaximumSpeed query",
                iterations: 1_000_000,
                action: () =>
                {
                    _ = prebuiltSimulation.MaximumSpeed();
                }),

            new BenchmarkScenario(
                name: "TimeOfImpact query",
                iterations: 1_000_000,
                action: () =>
                {
                    _ = prebuiltSimulation.TimeOfImpact();
                }),

            new BenchmarkScenario(
                name: "SampleReportLinesEvery(20)",
                iterations: 100_000,
                action: () =>
                {
                    _ = prebuiltSimulation.SampleReportLinesEvery(20);
                }),

            new BenchmarkScenario(
                name: "Summary",
                iterations: 1_000_000,
                action: () =>
                {
                    _ = prebuiltSimulation.Summary();
                }),
        };

        foreach (var scenario in scenarios)
        {
            var result = PerformanceHarness.Run(scenario);
            PerformanceHarness.Print(result);
        }
    }
}