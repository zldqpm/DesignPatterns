﻿namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("外观模式!");
            //外观模式（Facade Pattern）是一种结构型设计模式，它提供了一个统一的接口，用于访问子系统中的一组接口。外观模式通过创建一个高层次的接口，简化了对底层复杂子系统的操作，使得客户端代码更加简洁和易于使用。
            //外观模式的主要目的是提供一个简化的界面，隐藏底层复杂系统的复杂性，让客户端只需要与外观接口交互，而不需要了解底层子系统的具体实现细节。
            //使用外观模式可以实现以下目标：
            //1.封装复杂的子系统：通过提供一个外观接口，将复杂的子系统封装起来，隐藏其实现细节，使得客户端只需要与外观接口进行交互。
            //2.简化客户端代码：外观模式可以提供一个简化的接口，使得客户端代码更加清晰、简洁，并且减少与子系统之间的直接耦合。


            //外观模式在以下场景中特别有用：
            //1.简化复杂接口：当一个系统拥有复杂的接口结构或多个子系统时，可以使用外观模式来提供一个简化的接口，使得客户端能够更轻松地使用系统功能。外观模式可以将复杂的操作逻辑隐藏在背后，只暴露必要的接口给客户端。
            //2.解耦客户端和子系统：当客户端需要与多个子系统进行交互时，可以使用外观模式来实现解耦。外观模式将子系统的复杂性隐藏在背后，使得客户端只需要与外观对象进行交互，而不需要直接与各个子系统交互。
            //3.提供统一接口：当需要对一个子系统或一组相关子系统提供一个统一的接口时，可以使用外观模式。外观模式可以封装多个子系统的操作，提供一个统一的接口给客户端使用，简化了客户端的操作流程。
            //以下是一个应用外观模式的例子：

            //假设我们有一个音频播放器应用，它包含了音频解码、音量控制和播放控制等多个子系统。我们可以使用外观模式来创建一个音频播放器外观类，它封装了这些子系统的复杂性，提供一个简化的接口供客户端使用。
            AudioPlayerFacade audioPlayer = new AudioPlayerFacade();
            audioPlayer.PlayAudio("music.mp3", 80);
            // 暂停...
            audioPlayer.PauseAudio();
            // 停止...
            audioPlayer.StopAudio();
            //在上述示例中，我们创建了一个音频播放器外观类 `AudioPlayerFacade`，它封装了音频解码器、音量控制和播放控制等子系统的复杂性。客户端只需要与外观类进行交互，而不需要直接与各个子系统进行交互。
            //客户端代码中，我们使用外观类 `AudioPlayerFacade` 来播放音频文件。通过调用外观类的方法，内部会自动进行音频解码、音量控制和播放控制等操作，客户端无需了解具体的实现细节。
            //通过使用外观模式，我们将复杂的音频播放器系统进行了封装，提供了一个简化的接口给客户端使用，使得客户端操作更加简洁、直观，并且与子系统之间的耦合度降低。
            Console.ReadLine();
        }
    }
}