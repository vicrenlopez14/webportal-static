import 'package:flutter/gestures.dart';
import 'package:flutter/material.dart';
import 'package:profindweb/routes/routes.dart';

class NavigationItem extends StatelessWidget {
  const NavigationItem({Key? key, required this.title, required this.routeName})
      : super(key: key);

  final String title;
  final String routeName;

  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      onTap: () {
        navKey.currentState!.pushNamed(routeName);
      },
      child: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 50.0),
        child: Text(
          this.title,
          style: TextStyle(fontSize: 20.0),
        ),
      ),
    );
  }
}
