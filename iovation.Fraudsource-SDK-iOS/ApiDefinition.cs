using System;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace FraudForceSDK
{
    // @interface FraudForce : NSObject
    [BaseType(typeof(NSObject))]
    interface FraudForce
    {
        // +(void)start;
        [Static]
        [Export("start")]
        void Start();

        // +(void)startAfterDelay:(NSTimeInterval)delay;
        [Static]
        [Export("startAfterDelay:")]
        void StartAfterDelay(double delay);

        // +(void)stop __attribute__((deprecated("discrete control of device inspector is unnecessary, stop will be removed in a future release")));
        [Static]
        [Export("stop")]
        void Stop();

        // +(void)suspend __attribute__((deprecated("discrete control of device inspector is unnecessary, suspend will be removed in a future release")));
        [Static]
        [Export("suspend")]
        void Suspend();

        // +(void)resume __attribute__((deprecated("discrete control of device inspector is unnecessary, resume will be removed in a future release")));
        [Static]
        [Export("resume")]
        void Resume();

        // +(void)delegation:(id<FraudForceDelegate> _Nullable)delegate;
        [Static]
        [Export("delegation:")]
        void Delegation([NullAllowed] FraudForceDelegate @delegate);

        // +(NSString * _Nonnull)blackbox;
        [Static]
        [Export("blackbox")]
        string Blackbox { get; }
    }

    // @protocol FraudForceDelegate <NSObject>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface FraudForceDelegate
    {
        // @required -(BOOL)shouldEnableNetworkCalls;
        [Abstract]
        [Export("shouldEnableNetworkCalls")]
        bool ShouldEnableNetworkCalls { get; }
    }
}

