import 'package:bisku/features/auth/data/repos/login_repository/login_repo_impl.dart';
import 'package:bisku/features/auth/presentaion/manger/login_cubit/login_cubit.dart';
import 'package:bisku/features/auth/presentaion/views/widgets/login_view_body.dart';
import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';

class LoginView extends StatelessWidget {
  const LoginView({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: BlocProvider(
        create: (context) => LoginCubit(LoginRepoImplementation()),
        child: const LoginViewBody(),
      ),
    );
  }
}
