using CommonLib.Validations;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KabulTalk.Models;
using KabulTalk.Repositories;
using KabulTalk.Services;
using System.Collections.Generic;
using System.Windows.Media;

namespace KabulTalk.ViewModels
{
  [ObservableObject]
  public partial class SignupControlViewModel
  {
    private readonly INavigationService _navigationService;
    private readonly IAccountRepository _accountRepository;
    [ObservableProperty]
    private string _email = "";
    [ObservableProperty]
    private string _nickname = default!;
    [ObservableProperty]
    private string _cellPhone = default!;
    [ObservableProperty]
    private string _password = default!;
    [ObservableProperty]
    private string _passwordConfirm = default!;
    [ObservableProperty]
    private string _emailValidationText = "";
    [ObservableProperty]
    private string _validationText = "";
    [ObservableProperty]
    public Brush _emailValidationTextColor = default!;

    private Dictionary<string, bool> _validatingDict = default!;   

    [RelayCommand]
    private void Signup()
    {
      if (!IsValidSignup()) return;

      Save();
      _navigationService.Navigate(NaviType.Login);
    }

    private void Save()
    {
      Account account = GetAccount();
      _accountRepository.Save(account);
    }

    private Account GetAccount() => new()
    {
      Email = Email,
      Nickname = Nickname,
      CellPhone = CellPhone,
      Pwd = Password,
    };

    private void ClearValidating()
    {
      ValidatingDict.Clear();
      ValidationText = "";
    }

    private void SetValidating(string key)
    {
      ValidatingDict[key] = true;
      switch (key)
      {
        case "Email":
          ValidationText = "Email을 입력하세요.";
          break;
        case "ExistEmail":
          ValidationText = "이미 존재하는 Email입니다.";
          break;
        case "Nickname":
          ValidationText = "닉네임을 입력하세요.";
          break;
        case "CellPhone":
          ValidationText = "휴대전화번호를 입력하세요.";
          break;
        case "Password":
          ValidationText = "비밀번호를 입력하세요.";
          break;
        case "PasswordConfirm":
          ValidationText = "비밀번호 확인를 입력하세요.";
          break;
        case "DifferentPassword":
          ValidatingDict["Password"] = true;
          ValidatingDict["PasswordConfirm"] = true;
          ValidationText = "비밀번호와 재입력 값이 일치하지 않습니다.";
          break;
      }
      OnPropertyChanged(nameof(ValidatingDict));
    }

    private bool IsValidSignup()
    {
      var isNullText = delegate (string key, string value)
      {
        if (string.IsNullOrWhiteSpace(value))
        {
          SetValidating(key);
          return true;
        }
        return false;
      };

      ClearValidating();
      if (isNullText(nameof(Email), Email)) return false;

      // 실제 데이터에 Email존재하는지
      if (_accountRepository.ExistEmail(Email))
      {
        SetValidating("ExistEmail");
        return false;
      }

      if (isNullText(nameof(Nickname), Nickname)) return false;
      if (isNullText(nameof(CellPhone), CellPhone)) return false;
      if (isNullText(nameof(Password), Password)) return false;
      if (isNullText(nameof(PasswordConfirm), PasswordConfirm)) return false;

      if (Password != PasswordConfirm)
      {
        SetValidating("DifferentPassword");
        return false;
      }

      return true;
    }

    partial void OnEmailChanged(string value)
    {
      SetEmailValidation(value);
    }

    private EmailValidationType GetEmailValidation()
    {
      if (!DataValidation.IsValidEmail(Email))
      {
        return EmailValidationType.FormatError;
      }
      if (_accountRepository.ExistEmail(Email))
      {
        return EmailValidationType.AlreadyExists;
      }

      return EmailValidationType.None;
    }

    private void SetEmailValidation(string email)
    {
      if (string.IsNullOrWhiteSpace(email))
      {
        EmailValidationText = "";
        return;
      }

      switch (GetEmailValidation())
      {
        case EmailValidationType.FormatError:
          EmailValidationText = "이메일 형식에 맞지 않습니다.";
          EmailValidationTextColor = Brushes.Red;
          break;
        case EmailValidationType.AlreadyExists:
          EmailValidationText = "이미 존재하는 이메일입니다.";
          EmailValidationTextColor = Brushes.Red;
          break;
        default:
          EmailValidationText = "사용할 수 있는 이메일입니다.";
          EmailValidationTextColor = Brushes.Blue;
          break;
      }
    }

    public SignupControlViewModel(INavigationService navigationService, IAccountRepository accountRepository)
    {
      _navigationService = navigationService;
      _accountRepository = accountRepository;
    }

    public Dictionary<string, bool> ValidatingDict
    {
      get
      {
        if (_validatingDict == null)
        {
          _validatingDict = new Dictionary<string, bool>();
        }
        return _validatingDict;
      }
    }
  }

  enum EmailValidationType
  {
    None, AlreadyExists, FormatError
  }
}
