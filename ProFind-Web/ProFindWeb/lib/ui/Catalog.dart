import 'package:flutter/material.dart';

// Make a widget that contains a search bar, and presents results in cards
class CatalogPage extends StatefulWidget {
  const CatalogPage({Key? key}) : super(key: key);

  @override
  _CatalogPageState createState() => _CatalogPageState();
}

class _CatalogPageState extends State<CatalogPage> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Catalog'),
      ),
      body: Center(
        child: Container(
          child: Text(
            'Catalog page',
            style: TextStyle(fontSize: 30),
          ),
        ),
      ),
    );
  }
}