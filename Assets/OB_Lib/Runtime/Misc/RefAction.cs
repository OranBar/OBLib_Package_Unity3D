
using System;

public class RefAction
{
	public Action Value { get; set; } = () => { };

	public void SubscribeOnce(Action toSubscribe)
	{
		Action invokeThenUnsubscribe = null;
		invokeThenUnsubscribe = () =>
		{
			toSubscribe.Invoke();
			Value -= invokeThenUnsubscribe;
		};

		Value += invokeThenUnsubscribe;
	}

	public void Invoke()
	{
		Value?.Invoke();
	}

	public static RefAction operator +(RefAction a, Action toSubscribe)
	{
		a.Value += toSubscribe;
		return a;
	}

	public static RefAction operator -(RefAction a, Action toUnsubscribe)
	{
		a.Value -= toUnsubscribe;
		return a;
	}
}

public class RefAction<T>
{
	public Action<T> Value { get; set; } = (_) => { };

	public void SubscribeOnce(Action<T> toSubscribe)
	{
		Action<T> invokeThenUnsubscribe = null;
		invokeThenUnsubscribe = (arg) =>
		{
			toSubscribe.Invoke(arg);
			Value -= invokeThenUnsubscribe;
		};

		Value += invokeThenUnsubscribe;
	}

	public void Invoke(T arg)
	{
		Value?.Invoke(arg);
	}

	public static RefAction<T> operator +(RefAction<T> a, Action<T> toSubscribe)
	{
		a.Value += toSubscribe;
		return a;
	}

	public static RefAction<T> operator -(RefAction<T> a, Action<T> toUnsubscribe)
	{
		a.Value -= toUnsubscribe;
		return a;
	}
}

public class RefAction<T, U>
{
	public Action<T, U> Value { get; set; } = (_1, _2) => { };

	public void SubscribeOnce(Action<T, U> toSubscribe)
	{
		Action<T, U> invokeThenUnsubscribe = null;
		invokeThenUnsubscribe = (arg1, arg2) =>
		{
			toSubscribe.Invoke(arg1, arg2);
			Value -= invokeThenUnsubscribe;
		};

		Value += invokeThenUnsubscribe;
	}

	public void Invoke(T arg1, U arg2)
	{
		Value?.Invoke(arg1, arg2);
	}

	public static RefAction<T, U> operator +(RefAction<T, U> a, Action<T, U> toSubscribe)
	{
		a.Value += toSubscribe;
		return a;
	}

	public static RefAction<T, U> operator -(RefAction<T, U> a, Action<T, U> toUnsubscribe)
	{
		a.Value -= toUnsubscribe;
		return a;
	}
}

public class RefAction<T, U, V>
{
	public Action<T, U, V> Value { get; set; } = (_1, _2, _3) => { };

	public void SubscribeOnce(Action<T, U, V> toSubscribe)
	{
		Action<T, U, V> invokeThenUnsubscribe = null;
		invokeThenUnsubscribe = (arg1, arg2, arg3) =>
		{
			toSubscribe.Invoke(arg1, arg2, arg3);
			Value -= invokeThenUnsubscribe;
		};

		Value += invokeThenUnsubscribe;
	}

	public void Invoke(T arg1, U arg2, V arg3)
	{
		Value?.Invoke(arg1, arg2, arg3);
	}

	public static RefAction<T, U, V> operator +(RefAction<T, U, V> a, Action<T, U, V> toSubscribe)
	{
		a.Value += toSubscribe;
		return a;
	}

	public static RefAction<T, U, V> operator -(RefAction<T, U, V> a, Action<T, U, V> toUnsubscribe)
	{
		a.Value -= toUnsubscribe;
		return a;
	}
}

public class RefAction<T, U, V, Z>
{
	public Action<T, U, V, Z> Value { get; set; } = (_1, _2, _3, _4) => { };

	public void SubscribeOnce(Action<T, U, V, Z> toSubscribe)
	{
		Action<T, U, V, Z> invokeThenUnsubscribe = null;
		invokeThenUnsubscribe = (arg1, arg2, arg3, arg4) =>
		{
			toSubscribe.Invoke(arg1, arg2, arg3, arg4);
			Value -= invokeThenUnsubscribe;
		};

		Value += invokeThenUnsubscribe;
	}

	public void Invoke(T arg1, U arg2, V arg3, Z arg4)
	{
		Value?.Invoke(arg1, arg2, arg3, arg4);
	}

	public static RefAction<T, U, V, Z> operator +(RefAction<T, U, V, Z> a, Action<T, U, V, Z> toSubscribe)
	{
		a.Value += toSubscribe;
		return a;
	}

	public static RefAction<T, U, V, Z> operator -(RefAction<T, U, V, Z> a, Action<T, U, V, Z> toUnsubscribe)
	{
		a.Value -= toUnsubscribe;
		return a;
	}
}
