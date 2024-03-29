﻿using Ninject.Modules;

namespace BasicWPFApp.WPF;

internal class ViewModelModule : NinjectModule
{
	public override void Load()
	{
		Bind<MainWindowViewModel>().ToSelf().InTransientScope();
	}
}
