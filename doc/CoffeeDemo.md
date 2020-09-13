# Coffee Demo - Working notes

## 1. The simple model

Initially we start with a simple model using a *sequence* (COMMIT). This allows our fleshing out a modus operandi for home brewing:

```howl
‒ ⑂ Brew()
    → Pour(tap, kettle)
    ∧ kettle.Switch(✓)
    ∧ Pour(pouch, pot)
    ∧ kettle.enabled ? cont : done
    ∧ Pour(kettle, pot)
    ∧ Wait(minutes: 1)
    ∧ Pour(pot, cup);
```

In the original model, `Brew()` fails because the `Kettle` does not implement boiling. Let's model a kettle's behavior:

```

```
