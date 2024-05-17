import 'package:bisku/features/auth/data/repos/register_repository/register_repo_imp.dart';
import 'package:bisku/features/auth/presentaion/manger/register_cubit/register_cubit.dart';
import 'package:bisku/features/auth/presentaion/views/widgets/register_view_body.dart';
import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';

class RegisterView extends StatelessWidget {
  const RegisterView({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: BlocProvider(
        create: (context) => RegisterCubit(RegisterRepoImplementation()),
        child: const RegisterViewBody(),
      ),
    );
  }
}
