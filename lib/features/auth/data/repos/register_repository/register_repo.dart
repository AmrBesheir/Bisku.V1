
import 'package:bisku/features/auth/data/models/ResultStatus%20.dart';

abstract class RegisterRepo {
   Future<Stream<Result>> postUserRegisterData({required String firstName,
      required String lastName,
      required String email,
      required String password,
      required String phoneNumber});
}
