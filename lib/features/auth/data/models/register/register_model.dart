import 'package:bisku/features/auth/data/models/register/user.dart';

class RegisterModel {
  RegisterModel({
    required this.firstName,
    required this.lastName,
    required this.email,
    required this.phoneNumber,
    required this.passWord,
  });
  String firstName;
  String lastName;
  String email;
  String phoneNumber;
  String passWord;
  factory RegisterModel.from(json)
  {
    return RegisterModel(firstName: json['email'], lastName: json['displayName'], email: email, phoneNumber: phoneNumber, passWord: passWord)
  }
   factory RegisterModel.toUser(RegisterModel registerModel)
  {
    return User(firstName: registerModel.firstName,lastName: registerModel.lastName, email: registerModel.email, phoneNumber: registerModel.phoneNumber, passWord: registerModel.passWord,);
  }
}