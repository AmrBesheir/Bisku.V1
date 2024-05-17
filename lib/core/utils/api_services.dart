import 'package:dio/dio.dart';

class Api {
  final Dio dio = Dio();
  final String _baseUrl = 'http://biskueapi.runasp.net/api/Account/';

  Future<Response> postRegisterData(
      {required String endPoint,
      required String firstName,
      required String lastName,
      required String email,
      required String password,
      required String phone}) async {
    Map data = {
      'displayName': '$firstName $lastName',
      'firstName': firstName,
      'lastName': lastName,
      'email': email,
      'phoneNumber': phone,
      'password': password
    };
    return await dio.post('$_baseUrl$endPoint',
        data: data,
        options: Options(headers: {'Content-Type': 'application/json'}));
  }

  Future<void> postLoginData({
    required String endPoint,
    required String email,
    required String password,
  }) async {
    Map data = {'email': email, 'password': password};
    Response response = await dio.post('$_baseUrl$endPoint',
        data: data,
        options: Options(headers: {'Content-Type': 'application/json'}));
    if (response.statusCode == 200) {
      print(response.data);
    } else if (response.statusCode == 401) {
      print('unAuth');
    } else if (response.statusCode == 400) {
      print('errrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr');
    } else {
      print('errror');
    }
  }
}
