import 'package:flutter/material.dart';
import 'package:profindweb/routes/routes.dart';
import 'package:profindweb/widgets/navigation_item.dart';

class NavigationBarWeb extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Container(
      height: 100.0,
      child: Row(
        mainAxisSize: MainAxisSize.max,
        children: [
          NavigationItem(
            title: 'Home',
            routeName: routeHome,
          ),
          NavigationItem(
            title: 'Access',
            routeName: routeAccess,
          ),
          NavigationItem(
            title: 'Landing page (EN)',
            routeName: routeLandingPageEnglish,
          ),
          NavigationItem(
            title: 'Landing page (ES)',
            routeName: routeLandingPageSpanish,
          ),
        ],
      ),
    );
  }
}
