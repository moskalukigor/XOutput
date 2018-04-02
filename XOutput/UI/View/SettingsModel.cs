﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XOutput.UI.Component;

namespace XOutput.UI.View
{
    public class SettingsModel : ModelBase
    {
        private readonly Settings settings;

        private readonly ObservableCollection<string> languages = new ObservableCollection<string>();
        public ObservableCollection<string> Languages => languages;

        private string selectedLanguage;
        public string SelectedLanguage
        {
            get => LanguageManager.Instance.Language;
            set
            {
                if (selectedLanguage != value)
                {
                    selectedLanguage = value;
                    LanguageManager.Instance.Language = value;
                    OnPropertyChanged(nameof(SelectedLanguage));
                }
            }
        }

        public bool CloseToTray
        {
            get => settings.CloseToTray;
            set
            {
                if (settings.CloseToTray != value)
                {
                    settings.CloseToTray = value;
                    OnPropertyChanged(nameof(CloseToTray));
                }
            }
        }

        public SettingsModel(Settings settings)
        {
            this.settings = settings;
        }
    }
}
