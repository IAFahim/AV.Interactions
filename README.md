# AV.Interactions

![Header](documentation_header.svg)

[![Unity](https://img.shields.io/badge/Unity-2022.3%2B-000000.svg?style=flat-square&logo=unity)](https://unity.com)
[![License](https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square)](LICENSE.md)

Event-driven collision wrappers for decoupling logic.

## ✨ Features

- **OnTriggerEnterMono**: Exposes `OnTriggerEnter` as a UnityEvent.
- **Decoupling**: Allows logic scripts to subscribe to physics events without requiring physics code.

## 📦 Installation

Install via Unity Package Manager (git URL).

## 🚀 Usage

1. Create a Child GameObject with a Collider (IsTrigger).
2. Add `OnTriggerEnterMono`.
3. Hook up the `OnEnter` event in the Inspector.

## ⚠️ Status

- 🧪 **Tests**: Missing.
- 📘 **Samples**: None.
