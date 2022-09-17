// ignore_for_file: prefer_const_constructors

import 'package:fluent_ui/fluent_ui.dart';
import 'package:flutter/material.dart';
import 'package:profindweb/app_view.dart';
import 'package:profindweb/routes/routes.dart';
import 'package:profindweb/ui/HomePage.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Navigation bar web',
      navigatorKey: navKey,
      onGenerateRoute: RouteGenerator.generateRoute,
      builder: (_, child) => AppView(child: child!),
    );
  }
}
