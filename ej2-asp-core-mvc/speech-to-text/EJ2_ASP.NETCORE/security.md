---
layout: post
title: Security concerns in ##Platform_Name## SpeechToText Control | Syncfusion
description: Checkout and learn about Security concerns in ##Platform_Name## SpeechToText control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: SpeechToText
publishingplatform: ##Platform_Name##
documentation: ug
---

# Security concerns in ##Platform_Name## SpeechToText control

## Online dependency

The SpeechToText control typically relies on browser-based APIs, which may require an active internet connection. If an internet connection is unavailable, an offline fallback should be considered.

## Potential security risks

Understanding the risks associated with speech recognition.

### Data transmission to external servers

The audio data is sent to third-party servers (e.g., Google, Microsoft) for processing. So the sensitive spoken information might be exposed to external entities.

### Privacy concerns

Some services may store user voice data for analytics or improving AI models. Users should verify browser and service policies.

### Man-in-the-Middle (MITM) attacks

Without HTTPS, attackers could intercept audio data during transmission.

### Browser and permission exploits

Malicious websites may misuse permissions to eavesdrop on conversations. Explicit user consent is essential before enabling microphone access.

## Mitigation strategies

Ensuring security and privacy when using speech recognition and how to mitigate them.

* Use the control only in trusted environments.
* Inform users about third-party data processing.
* Enforce HTTPS to secure audio transmission.
* Request microphone permissions only when required and revoke them afterward.
* Review browser API privacy policies for speech recognition.
