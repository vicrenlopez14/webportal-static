import 'package:flutter/material.dart';

class AccessPage extends StatelessWidget {
  const AccessPage({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Access'),
      ),
      body: Center(
        child: Container(
          child: Text(
            'Access page',
            style: TextStyle(fontSize: 30),
          ),
        ),
      ),
    );
  }
}
