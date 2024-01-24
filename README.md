本项目为在b站大学上[丑萌气质狗](https://space.bilibili.com/90189489)老师的[WPF课程](https://www.bilibili.com/video/BV13D4y1u7XX)写的示例代码

与老师的代码有出入，但是可以达到玩耍和演示的效果，应该是足够学习的了

适合不想要跟着老师抄代码，但是想要看看样式效果的同学

虽然说自己动手写一写代码总归是好事

但是这样的效率可能会更高一点——你可以Clone这个项目，在本地任意的玩耍，调整，省去的抄代码的时间

## 使用方法

1. 在`App.xaml`中修改启动页面为你需要查看的`页面.xaml`，启动项目。
2. 将你想要演示的页面代码的`<Window>`标签以内的内容替换`MainWindow.xaml`，启动项目。

看老师前几节课的人，应该都知道怎么做的吧~

更建议使用第一个方法。

## 目录

|                            文件名                            | 对应课程 |                           我的笔记                           |
| :----------------------------------------------------------: | :------: | :----------------------------------------------------------: |
|                      04简易记事本.xaml                       |    04    | [布局控件：Grid和StackPanel ](https://www.cnblogs.com/Vanilla-chan/p/17975309/Grid-and-StackPanel) |
|                     05宽高尺寸演示.xaml                      |    05    |                             同上                             |
|               07定义Style样式与样式的继承.xaml               |  06、07  | [Style：用法，多样性，全局样式与资源字典](https://www.cnblogs.com/Vanilla-chan/p/17977421/Style-Usage-and-Global-Style) |
|                    08全局样式的定义.xaml                     |    08    |                             同上                             |
|             09自定义按钮模板以及设置触发器.xaml              |    09    | [自定义按钮模板以及设置触发器](https://www.cnblogs.com/Vanilla-chan/p/17978658/Customized-Button-Templates) |
|           10C#代码事件.xaml & 10C#代码事件.xaml.cs           |    10    | [C#代码事件](https://www.cnblogs.com/Vanilla-chan/p/17983427/CSharp-Code-Events) |
| 11图书馆程序（一）.xaml & 11图书馆程序（一）.xaml.cs & Index.xaml |  11-13   |                              无                              |
| 14图书馆程序（二）绑定.xaml & 14图书馆程序（二）绑定.xaml.cs |  14-15   | [WPF绑定与通知属性到界面](https://www.cnblogs.com/Vanilla-chan/p/17986203/Binding-and-Live-Update) |
|                                                              |          |                                                              |
|                                                              |          |                                                              |
|                                                              |          |                                                              |
|                                                              |          |                                                              |

### 注意事项

08课程中修改了全局样式，需要修改`App.xaml`，替换为以下代码：

```xaml
<Application x:Class="WPF_Study.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:local="clr-namespace:WPF_Study"
             StartupUri="MainWindow.xaml">
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="/WPF_Study;component/BaseButtomStyle.xaml"/>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

10、11、14有用到后端代码`10C#代码事件.xaml.cs`，若复制使用需要一并复制。

还是修改`App.xaml`更方便一点。

## 协议

MIT协议