
import 'package:bisku/features/auth/data/models/ResultStatus%20.dart';
import 'package:bisku/features/auth/data/repos/register_repository/register_repo.dart';
import 'package:bisku/features/auth/presentaion/manger/register_cubit/register_states.dart';
import 'package:bloc/bloc.dart';

class RegisterCubit extends Cubit<RegisterStates> {
  RegisterCubit(this.registerRepo) : super(RegisterInistialState());
  final RegisterRepo registerRepo;

  Future<void> postUserRegister(
      {required String firstName,
      required String lastName,
      required String email,
      required String password,
      required String phoneNumber}) async {
    try {
     var resultStream = await registerRepo.postUserRegisterData(
      firstName: firstName,
      lastName: lastName,
      email: email,
      password: password,
      phoneNumber: phoneNumber,
    );

     resultStream.listen(( result ) {
      // Handle different result states
      if (result.isLoading) {
          emit(RegisterLoadingState());
      } else if (result.isSuccess) {
           emit(RegisterSuccsessState());
        var data = result.data; // Access the registration result data
        print('User registered successfully: $data');
      } else if (result.isFailed) {
            emit(RegisterFailureState());
        print('Registration failed: ${result.error}');
      }
    });
    } on Exception catch (e) {
      emit(RegisterFailureState());
    }
  }
}
