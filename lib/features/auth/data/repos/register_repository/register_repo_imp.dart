import 'dart:async';

import 'package:bisku/core/utils/api_services.dart';
import 'package:bisku/features/auth/data/models/ResultStatus%20.dart';
import 'package:bisku/features/auth/data/repos/register_repository/register_repo.dart';

class RegisterRepoImplementation implements RegisterRepo {
  final Api api = Api();
  RegisterRepoImplementation();

  @override
  Future<Stream<Result>> postUserRegisterData(
      {required String firstName,
      required String lastName,
      required String email,
      required String password,
      required String phoneNumber}) async {
    StreamController<Result> _resultController =
        StreamController();

    try {
      _resultController.add(Result.loading());

      var response = await api.postRegisterData(
        endPoint: 'register',
        email: email,
        firstName: firstName,
        lastName: lastName,
        password: password,
        phone: phoneNumber,
      );

      if (response.statusCode == 200 || response.statusCode == 201) {
        if (response.data == null) {
          _resultController.add(Result.failed('error'));
        } else {
          // Successful response
          _resultController.add(Result.success(response.data));
        }
      } else if (response.statusCode == 401) {
        // Unauthorized
        _resultController.add(Result.failed('Unauthorized'));
      } else if (response.statusCode == 400) {
        // Bad request
        _resultController.add(Result.failed('Bad request'));
      } else {
        // Other error
        _resultController.add(Result.failed('Unknown error'));
      }
    } on Exception catch (e) {
      _resultController.add(Result.failed(e.toString()));
    }
    return _resultController.stream.cast<Result>();
  }
}
