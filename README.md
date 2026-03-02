# MediaElement iOS Audio Session Reproduction

Minimal reproduction project for a CommunityToolkit.Maui.MediaElement bug where a muted, autoplaying `MediaElement` on iOS unconditionally claims the `AVAudioSession` with `CategoryPlayback`, interrupting background audio from other apps.

## The Bug

Even when `ShouldMute="True"`, the `MediaElement`'s underlying `AVPlayer` activates the audio session in a way that pauses/interrupts any other audio source (Spotify, Apple Music, podcasts, etc.).

## How to Reproduce

1. Open this project and deploy to an iOS device or simulator.
2. Before launching, start playing audio from another app (e.g. Spotify).
3. Launch this app.
4. Observe that background audio is interrupted when the muted video begins autoplay.

## Environment

- .NET MAUI 10.x
- CommunityToolkit.Maui.MediaElement 8.0.0
- iOS 18.x (also reproducible on earlier versions)

## Build

```bash
dotnet build -f net10.0-ios
```
